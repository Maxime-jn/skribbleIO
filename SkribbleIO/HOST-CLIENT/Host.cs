using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace SkribbleIO
{
    public class Host
    {
        private TcpListener listener;
        private List<TcpClient> clients = new List<TcpClient>();
        private bool isRunning = false;

        public event Action<string> OnMessageReceived;

        public void Start(int port)
        {
            listener = new TcpListener(IPAddress.Any, port);
            listener.Start();
            isRunning = true;

            Task.Run(() => AcceptClient());
        }
        private async Task AcceptClient()
        {
            while (isRunning)
            {
                var client = await listener.AcceptTcpClientAsync();
                lock (clients) clients.Add(client);
<<<<<<< Updated upstream
<<<<<<< Updated upstream
                _ = Task.Run(() => HandleClient(client));
                Console.WriteLine("Client connecté");
=======
                //_ = Task.Run(() => HandleClient(client));
>>>>>>> Stashed changes
=======
                //_ = Task.Run(() => HandleClient(client));
>>>>>>> Stashed changes
            }
        }
        private async Task HandleClient(TcpClient client)
        {
            var stream = client.GetStream();
            byte[] buffer = new byte[1024];
            while (isRunning)
            {
                try
                {
                    int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
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
            client.Close();
        }
        private void Broadcast(string message, TcpClient sender)
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
                            client.GetStream().Write(buffer, 0, buffer.Length);
                        }
                        catch { }
                    }
                }
            }
        }

        public void Stop()
        {
            isRunning = false;
            listener.Stop();
            lock (clients)
            {
                foreach (var client in clients) client.Close();
            }
            clients.Clear();
        }
    }
}

