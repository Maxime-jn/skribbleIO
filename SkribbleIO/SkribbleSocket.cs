using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ChatLib_Others
{
    public class SkribbleSocket
    {
        private Socket? socket = null;
        private IPEndPoint endPoint = null;
        private bool isServer { get; set; }
        private Task Initialization { get; set; }
        private string file { get; set; }
        private string srvIp { get; set; }
        public SkribbleSocket(bool isSrv)
        {
            isServer = isSrv;
            Initialization = Initialize(isServer);


        }

        /// <summary>
        /// this method initialize the socket
        /// </summary>
        /// <returns> Task<bool> </returns>
        public async Task<bool> Initialize(bool isServer)
        {
            bool isValid = false;
            try
            {
                // traitement...



                SocketConfig socketConf = readConfig();
                if (socketConf.isValid())
                {
                    endPoint = new IPEndPoint(IPAddress.Parse(socketConf.ip), socketConf.port);
                    socket = new Socket(endPoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    if (socketConf.srvIp != null)
                    {
                        srvIp = socketConf.srvIp;
                    }
                }

                if (isValid)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERREUR -> ChatSocket.cs, Initialize() // " + e.Message);
                return false;
            }
        }

        public void SetSocket(Socket socket)
        {
            this.socket = socket;
        }

        /// <summary>
        /// The Socket config values
        /// </summary>
        /// <remarks>These values are read from the socketConfig.json</remarks>
        /// <see cref="readConfig"/>
        internal class SocketConfig
        {
            public string protocol { get; set; }
            public int type { get; set; }
            public string ip { get; set; }
            public int port { get; set; }
            public string? srvIp { get; set; }

            /// <summary>
            /// Is this config object valid?
            /// </summary>
            /// <returns>True if valid</returns>
            /// 
            public bool isValid()
            {

                return (!string.IsNullOrEmpty(ip));
            }

            public void SocketInfo()
            {
                if (srvIp != null)
                {
                    Console.WriteLine($"[{this.ip}]: type: {this.type}, port: {this.port}, server IP: {this.srvIp}");
                }
                else
                {
                    Console.WriteLine($"[{this.ip}]: type: {this.type}, port: {this.port}");
                }
            }
        }

        /// <summary>
        /// Read the socket config from the socketConfig.json
        /// </summary>
        /// <remarks>Use isValid() function to check if the object is valid.
        /// For this demonstration, put the socketConfig.json where you have your project solution
        /// </remarks>
        /// <returns>EDBConfig</returns>
        private SocketConfig readConfig()
        {
            if (isServer)
            {
                file = "./srvSocketConfig.json";
            }
            else
            {
                file = "./cliSocketConfig.json";
            }

            SocketConfig conf = new SocketConfig();
            try
            {

                using (StreamReader r = new StreamReader(file))
                {
                    string json = r.ReadToEnd();
                    Console.WriteLine(json);
                    conf = JsonSerializer.Deserialize<SocketConfig>(json);
                }
            }
            catch (Exception ex)
            {
                // Nothing to do here, except if you want
                // to log the error.
                // anyway, the conf returned will be invalid
            }
            return conf;
        }
        /// <summary>
        /// returns socket
        /// </summary>
        /// <returns> Socket </returns>
        public Socket GetSocket()
        {
            return socket;
        }
        /// <summary>
        /// returns endPoint
        /// </summary>
        /// <returns> IPEndPoint </returns>
        public IPEndPoint GetEndPoint()
        {
            return endPoint;
        }

        /// <summary>
        /// returns srvIp
        /// </summary>
        /// <returns> string </returns>
        public string GetSrvIp()
        {
            return srvIp;
        }
    }
}
