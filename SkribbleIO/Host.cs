using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ChatLib_Others; // Reference your SkribbleSocket class

namespace SkribbleIO
{
    public class Host
    {
        public event Action<string> OnClientConnected;
        public event Action<string> OnClientDisconnected;
        public event Action<string> OnMessageReceived;

        public SkribbleSocket skribbleSocket { get; private set; }

        private Socket listener;
        private List<Socket> clients = new List<Socket>();
        private bool isRunning = false;

        public Host()
        {
            // Initialize as server
            skribbleSocket = new SkribbleSocket(true);
        }

        public async void Start()
        {
            bool initialized = await skribbleSocket.Initialize(true);
            if (!initialized)
            {
                Console.WriteLine("Failed to initialize server socket.");
                return;
            }

            listener = skribbleSocket.GetSocket();
            listener.Bind(skribbleSocket.GetEndPoint());
            listener.Listen(10);
            isRunning = true;

            _ = Task.Run(() => AcceptClient());
        }

        private async Task AcceptClient()
        {
            while (isRunning)
            {
                try
                {
                    var client = await listener.AcceptAsync();
                    lock (clients) clients.Add(client);

                    _ = Task.Run(() => HandleClient(client));
                    Console.WriteLine("Client connecté");

                    var endpoint = client.RemoteEndPoint.ToString();
                    OnClientConnected?.Invoke(endpoint);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error accepting client: " + ex.Message);
                }
            }
        }

        private async Task HandleClient(Socket client)
        {
            byte[] buffer = new byte[1024];
            while (isRunning)
            {
                try
                {
                    int bytesRead = await client.ReceiveAsync(buffer, SocketFlags.None);
                    if (bytesRead == 0) break;

                    string msg = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                    OnMessageReceived?.Invoke(msg);
                    Broadcast(msg, client);
                }
                catch
                {
                    break;
                }
            }

            lock (clients) clients.Remove(client);
            var endpoint = client.RemoteEndPoint.ToString();
            OnClientDisconnected?.Invoke(endpoint);
            client.Close();
        }

        private void Broadcast(string message, Socket sender)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            lock (clients)
            {
                foreach (var client in clients)
                {
                    if (client != sender)
                    {
                        try
                        {
                            client.Send(buffer);
                        }
                        catch { }
                    }
                }
            }
        }

        public void Stop()
        {
            isRunning = false;
            listener.Close();
            lock (clients)
            {
                foreach (var client in clients) client.Close();
            }
            clients.Clear();
        }
    }
}
