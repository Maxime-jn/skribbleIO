using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SkribbleIO
{
    public class Server
    {
        private Socket listener;
        private List<Socket> clients = new();
        private Dictionary<string, (string username, Socket socket)> players = new();


        public event Action<string, string> PlayerJoined;
        public event Action<string, string> PlayerLeft;
        public event Action<string, string, string> ChatMessage;
        public event Action<string, string> CanvasUpdate;
        public event Action<string> StartGame;




        public void Start(int port)
        {
            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(new IPEndPoint(IPAddress.Any, port));
            listener.Listen(10);
            listener.BeginAccept(OnClientAccepted, null);
        }

        private void OnClientAccepted(IAsyncResult ar)
        {
            Socket client = listener.EndAccept(ar);
            clients.Add(client);
            BeginReceive(client);
            listener.BeginAccept(OnClientAccepted, null);
        }

        private void BeginReceive(Socket client)
        {
            var buffer = new byte[8192];
            client.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ar =>
            {
                try
                {
                    int received = client.EndReceive(ar);
                    if (received == 0)
                    {
                        RemoveClient(client);
                        return;
                    }
                    string msg = Encoding.UTF8.GetString(buffer, 0, received);
                    HandleMessage(client, msg);
                    BeginReceive(client);
                }
                catch
                {
                    RemoveClient(client);
                }
            }, null);
        }

        private void RemoveClient(Socket client)
        {
            clients.Remove(client);
            string ip = ((IPEndPoint)client.RemoteEndPoint).Address.ToString();
            if (players.TryGetValue(ip, out var info))
            {
                PlayerLeft?.Invoke(info.username, ip);
                Broadcast($"playerLeft::{info.username}::{ip}<|EOM|>");
                players.Remove(ip);
            }
            client.Close();
        }

        private void HandleMessage(Socket client, string msg)
        {
            foreach (var part in msg.Split(new[] { "<|EOM|>" }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (part.StartsWith("playerJoined::"))
                {
                    var split = part.Split(new[] { "::" }, StringSplitOptions.None);
                    string username = split[1];
                    string ip = split[2];
                    players[ip] = (username, client);
                    PlayerJoined?.Invoke(username, ip);
                    Broadcast($"playerJoined::{username}::{ip}<|EOM|>");
                }
                else if (part.StartsWith("chat::"))
                {
                    var split = part.Split(new[] { "::" }, StringSplitOptions.None);
                    string ip = split[1];
                    string username = split[2];
                    string message = split[3];
                    ChatMessage?.Invoke(ip, username, message);
                    Broadcast($"chat::{ip}::{username}::{message}<|EOM|>");
                }
                else if (part.StartsWith("canvasUpdate::"))
                {
                    var split = part.Split(new[] { "::" }, StringSplitOptions.None);
                    string ip = split[1];
                    string base64 = split[2];
                    CanvasUpdate?.Invoke(ip, base64);
                    Broadcast($"canvasUpdate::{ip}::{base64}<|EOM|>");
                }
                else if (part.StartsWith("startGame::"))
                {
                    var split = part.Split(new[] { "::" }, StringSplitOptions.None);
                    string ip = split[1];
                    StartGame?.Invoke(ip);
                    Broadcast($"startGame::{ip}<|EOM|>");
                }
            }
        }


        private static bool IsBase64String(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
                return false;
            s = s.Trim();
            return (s.Length % 4 == 0) &&
                   System.Text.RegularExpressions.Regex.IsMatch(s, @"^[a-zA-Z0-9\+/]*={0,2}$", System.Text.RegularExpressions.RegexOptions.None);
        }
        public void Broadcast(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            foreach (var client in clients)
            {
                try { client.BeginSend(data, 0, data.Length, SocketFlags.None, null, null); }
                catch { }
            }
        }
    }
}
