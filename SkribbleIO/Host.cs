using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using ChatLib_Others;

namespace SkribbleIO
{
    public class Host
    {
        public event Action<string> OnClientConnected;
        public event Action<string> OnClientDisconnected;
        public event Action<string> OnMessageReceived;

        public SkribbleSocket skribbleSocket { get; private set; }

        private static ManualResetEvent mreAccept = new ManualResetEvent(false);
        private static ManualResetEvent mreReceive = new ManualResetEvent(false);
        private Socket listener;
        private ConcurrentDictionary<string, Socket> clients = new();
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

            Console.WriteLine("[Server] Hosting on: " + skribbleSocket.GetEndPoint());

            ThreadPool.QueueUserWorkItem(_ => AcceptLoop());
        }

        private void AcceptLoop()
        {
            while (isRunning)
            {
                try
                {
                    mreAccept.Reset();
                    listener.BeginAccept(OnClientAccepted, null);
                    mreAccept.WaitOne(); // Wait for a connection
                    Thread.Sleep(10); // avoid tight loop
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in AcceptLoop: " + ex.Message);
                }
            }
        }

        private void OnClientAccepted(IAsyncResult ar)
        {
            Socket clientSocket = null;
            try
            {
                clientSocket = listener.EndAccept(ar);
                string clientKey = clientSocket.RemoteEndPoint.ToString();

                if (clients.TryAdd(clientKey, clientSocket))
                {
                    Console.WriteLine("[Server] New client connected: " + clientKey);
                    OnClientConnected?.Invoke(clientKey);

                    var state = new StateObject
                    {
                        WorkSocket = clientSocket
                    };

                    clientSocket.BeginReceive(state.Buffer, 0, StateObject.BufferSize, 0, OnReceive, state);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in OnClientAccepted: " + ex.Message);
                clientSocket?.Close();
            }
        }

        private void OnReceive(IAsyncResult ar)
        {
            StateObject state = (StateObject)ar.AsyncState;
            Socket clientSocket = state.WorkSocket;

            try
            {
                int bytesRead = clientSocket.EndReceive(ar);

                if (bytesRead > 0)
                {
                    string msg = Encoding.UTF8.GetString(state.Buffer, 0, bytesRead);
                    OnMessageReceived?.Invoke(msg);

                    Broadcast(msg, clientSocket);
                    clientSocket.BeginReceive(state.Buffer, 0, StateObject.BufferSize, 0, OnReceive, state);
                }
                else
                {
                    DisconnectClient(clientSocket);
                }
            }
            catch
            {
                DisconnectClient(clientSocket);
            }
        }

        private void Broadcast(string message, Socket sender)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            string senderKey = sender.RemoteEndPoint.ToString();

            foreach (var kvp in clients)
            {
                if (kvp.Key != senderKey)
                {
                    try
                    {
                        kvp.Value.Send(buffer);
                    }
                    catch
                    {
                        DisconnectClient(kvp.Value);
                    }
                }
            }
        }

        private void DisconnectClient(Socket client)
        {
            string key = client.RemoteEndPoint?.ToString();
            if (key != null && clients.TryRemove(key, out _))
            {
                OnClientDisconnected?.Invoke(key);
                Console.WriteLine("[Server] Client disconnected: " + key);
            }

            try
            {
                client.Shutdown(SocketShutdown.Both);
            }
            catch { }
            finally
            {
                client.Close();
            }
        }

        public void Stop()
        {
            isRunning = false;
            listener.Close();

            foreach (var kvp in clients)
            {
                try { kvp.Value.Close(); } catch { }
            }

            clients.Clear();
        }
    }

    internal class StateObject
    {
        public Socket WorkSocket = null;
        public const int BufferSize = 1024;
        public byte[] Buffer = new byte[BufferSize];
    }
}
