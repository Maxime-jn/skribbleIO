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
                _ = Task.Run(() => HandleClient(client));
            }
        }   
    }
}
