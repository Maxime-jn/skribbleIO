using ChatLib_Others;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SkribbleIO
{
    public class Client
    {
        private static Client instance = null;
        private Socket sender;
        private IPEndPoint endPoint;
        private string srvIp;
        private const string messageEOM = "<|EOM|>";
        private StringBuilder receivedData = new StringBuilder();

        public event Action<string> OnMessageReceived;

        private Client()
        {
            Initialize();
        }

        public static Client GetInstance()
        {
            if (instance == null)
                instance = new Client();
            return instance;
        }

        private void Initialize()
        {
            try
            {
                var socketConfig = new SkribbleSocket(false);
                socketConfig.Initialize(false).Wait(); // ← juste pour obtenir IP & port
                sender = socketConfig.GetSocket();
                endPoint = socketConfig.GetEndPoint();
                srvIp = socketConfig.GetSrvIp();

                sender.BeginConnect(IPAddress.Parse(srvIp), endPoint.Port, OnConnected, null);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Client.Initialize(): " + ex.Message);
            }
        }

        private void OnConnected(IAsyncResult ar)
        {
            try
            {
                sender.EndConnect(ar);
                Console.WriteLine("Connecté au serveur.");
                StartReceiving();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la connexion: " + ex.Message);
            }
        }

        public void SendMessage(string message)
        {
            try
            {
                if (sender != null && sender.Connected)
                {
                    string fullMessage = $"{message}{messageEOM}";
                    byte[] data = Encoding.UTF8.GetBytes(fullMessage);
                    sender.BeginSend(data, 0, data.Length, SocketFlags.None, OnSendComplete, null);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Client.SendMessage(): " + ex.Message);
            }
        }

        private void OnSendComplete(IAsyncResult ar)
        {
            try
            {
                int bytesSent = sender.EndSend(ar);
                Console.WriteLine($"[Client] {bytesSent} octets envoyés.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Client.OnSendComplete(): " + ex.Message);
            }
        }

        private void StartReceiving()
        {
            try
            {
                StateObject state = new StateObject();
                state.WorkSocket = sender;
                sender.BeginReceive(state.Buffer, 0, StateObject.BufferSize, 0, OnReceive, state);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Client.StartReceiving(): " + ex.Message);
            }
        }

        private void OnReceive(IAsyncResult ar)
        {
            try
            {
                StateObject state = (StateObject)ar.AsyncState;
                Socket socket = state.WorkSocket;

                int bytesRead = socket.EndReceive(ar);
                if (bytesRead > 0)
                {
                    string received = Encoding.UTF8.GetString(state.Buffer, 0, bytesRead);
                    receivedData.Append(received);

                    while (receivedData.ToString().Contains(messageEOM))
                    {
                        string full = receivedData.ToString();
                        int index = full.IndexOf(messageEOM);
                        string message = full.Substring(0, index);
                        receivedData.Remove(0, index + messageEOM.Length);

                        OnMessageReceived?.Invoke(message);
                    }

                    socket.BeginReceive(state.Buffer, 0, StateObject.BufferSize, 0, OnReceive, state);
                }
                else
                {
                    Console.WriteLine("Connexion fermée par le serveur.");
                    socket.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur Client.OnReceive(): " + ex.Message);
            }
        }

        internal class StateObject
        {
            public Socket WorkSocket = null;
            public const int BufferSize = 1024;
            public byte[] Buffer = new byte[BufferSize];
        }
    }
}
