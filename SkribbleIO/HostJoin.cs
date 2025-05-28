using System;
using System.Windows.Forms;
using SkribbleIO;

namespace SkribbleIO
{
    public partial class HostJoin : Form
    {
        private Host hoster;

        public HostJoin()
        {
            InitializeComponent();
            hoster = new Host();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            await Task.Run(() => hoster.Start()); // Start host using config

            Lobby lobbyForm = new Lobby(); // Pass host instance to Lobby
            lobbyForm.Show();
            lobbyForm.GetHost(hoster);
            hoster.Start();
            this.Hide();
        }
        private void btnJoin_Click(object sender, EventArgs e)
        {
            try
            {
                var client = Client.GetInstance();
                client.OnMessageReceived += Client_OnMessageReceived;

                MessageBox.Show("Connecté au serveur !");

                Lobby lobbyForm = new Lobby(); // Pass host instance to Lobby
                lobbyForm.Show();
                lobbyForm.GetClient(client);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la connexion : {ex.Message}");
            }
        }

        private void Client_OnMessageReceived(string msg)
        {
            Console.WriteLine("Message reçu du serveur: " + msg);
            // Handle message display or game state update here
        }

    }
}
