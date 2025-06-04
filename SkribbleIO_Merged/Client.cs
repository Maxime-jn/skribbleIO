using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SkribbleIO
{
    public class Client
    {
        private Socket socket;
        public event Action<string, string> PlayerJoined;
        public event Action<string, string> PlayerLeft;
        public event Action<string, string, string> ChatMessage;
        public event Action<string, string> CanvasUpdate;
        public event Action<string> StartGame;

        public void Connect(string ip, int port)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.BeginConnect(new IPEndPoint(IPAddress.Parse(ip), port), ar =>
            {
                socket.EndConnect(ar);
                BeginReceive();
            }, null);
        }

        private void BeginReceive()
        {
            var buffer = new byte[8192];
            socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, ar =>
            {
                try
                {
                    int received = socket.EndReceive(ar);
                    if (received == 0) return;
                    string msg = Encoding.UTF8.GetString(buffer, 0, received);
                    HandleMessage(msg);
                    BeginReceive();
                }
                catch { }
            }, null);
        }

        private void HandleMessage(string msg)
        {
            foreach (var part in msg.Split(new[] { "<|EOM|>" }, StringSplitOptions.RemoveEmptyEntries))
            {
                if (part.StartsWith("playerJoined::"))
                {
                    var split = part.Split(new[] { "::" }, StringSplitOptions.None);
                    PlayerJoined?.Invoke(split[1], split[2]);
                }
                else if (part.StartsWith("playerLeft::"))
                {
                    var split = part.Split(new[] { "::" }, StringSplitOptions.None);
                    PlayerLeft?.Invoke(split[1], split[2]);
                }
                else if (part.StartsWith("chat::"))
                {
                    var split = part.Split(new[] { "::" }, StringSplitOptions.None);
                    ChatMessage?.Invoke(split[1], split[2], split[3]);
                }
                else if (part.StartsWith("canvasUpdate::"))
                {
                    var split = part.Split(new[] { "::" }, StringSplitOptions.None);
                    CanvasUpdate?.Invoke(split[1], split[2]);
                }
                else if (part.StartsWith("startGame::"))
                {
                    var split = part.Split(new[] { "::" }, StringSplitOptions.None);
                    StartGame?.Invoke(split[1]);
                }
            }
        }

        public void Send(string message)
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, null, null);
        }
    }
}
