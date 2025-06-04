using System;
using System.Windows.Forms;

namespace SkribbleIO
{
    public partial class HostJoin : Form
    {
        public static Server? server;
        public static Client? client;
        public static string? username;
        public static string? myIp;

        public HostJoin()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Génère un username automatique
            username = "Joueur" + new Random().Next(1000, 9999);
            myIp = "127.0.0.1";

            // Lance le serveur
            server = new Server();
            server.Start(5000);

            // Lance le client (host)
            client = new Client();
            client.Connect("127.0.0.1", 5000);

            // S'enregistre auprès du serveur
            client.Send($"playerJoined::{username}::{myIp}<|EOM|>");

            // Ouvre le lobby
            Lobby lobby = new Lobby();
            lobby.Show();
            this.Hide();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            string ip = tbxIpHost.Text.Trim();
            if (string.IsNullOrEmpty(ip)) return;

            username = "Joueur" + new Random().Next(1000, 9999);
            myIp = ip;

            client = new Client();
            client.Connect(ip, 5000);

            // S'enregistre auprès du serveur
            client.Send($"playerJoined::{username}::{myIp}<|EOM|>");

            // Ouvre le lobby
            Lobby lobby = new Lobby();
            lobby.Show();
            this.Hide();
        }
    }
}
