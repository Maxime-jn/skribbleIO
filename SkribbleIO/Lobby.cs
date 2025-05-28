using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SkribbleIO;

namespace SkribbleIO
{
    public partial class Lobby : Form
    {
        private Host hoster;
        private Client client;

        public Lobby()
        {
            InitializeComponent();
        }

        public void GetHost(Host hoster)
        {
            this.hoster = hoster;
            // Subscribe to events
            hoster.OnClientConnected += Host_OnClientConnected;
            hoster.OnClientDisconnected += Host_OnClientDisconnected;

            // Start hosting on form load
            hoster.Start(); // no port needed if using SkribbleSocket's config

            // Display IP from config (if any)
            var ip = hoster?.skribbleSocket?.GetEndPoint()?.Address.ToString();
            if (!string.IsNullOrWhiteSpace(ip))
                lbl_ip.Text = $"Server IP: {ip}";
        }
        public void GetClient()
        {
            this.client = Client.GetInstance();
            this.client.OnMessageReceived += Client_OnMessageReceived;

            client.SendMessage("coucou");
        }

        private void Client_OnMessageReceived(string message)
        {
            // Affichage dans l'interface ou traitement
            MessageBox.Show("Reçu du serveur : " + message);
        }
        private void Lobby_Load(object sender, EventArgs e)
        {

        }

        private void Host_OnClientConnected(string clientInfo)
        {
            if (clbxPlayers.InvokeRequired)
            {
                clbxPlayers.Invoke(new Action(() => clbxPlayers.Items.Add(clientInfo)));
            }
            else
            {
                clbxPlayers.Items.Add(clientInfo);
            }
        }

        private void Host_OnClientDisconnected(string clientInfo)
        {
            if (clbxPlayers.InvokeRequired)
            {
                clbxPlayers.Invoke(new Action(() => clbxPlayers.Items.Remove(clientInfo)));
            }
            else
            {
                clbxPlayers.Items.Remove(clientInfo);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {


            Game game = new Game();
            game.Show();
            this.Hide();
        }
    }
}
