using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SkribbleIO
{
    public partial class Lobby : Form
    {
        private List<(string username, string ip)> players = new();

        public Lobby()
        {
            InitializeComponent();

            // Souscrit aux événements du client
            HostJoin.client.PlayerJoined += OnPlayerJoined;
            HostJoin.client.PlayerLeft += OnPlayerLeft;
            HostJoin.client.StartGame += OnStartGame;

            this.Load += Lobby_Load;
        }

        private void Lobby_Load(object? sender, EventArgs e)
        {
            // Ajoute le joueur local à la liste si absent
            if (!players.Exists(p => p.ip == HostJoin.myIp))
            {
                players.Add((HostJoin.username, HostJoin.myIp));
                UpdatePlayerList();
            }
        }

        private void OnPlayerJoined(string username, string ip)
        {
            if (!players.Exists(p => p.ip == ip))
            {
                players.Add((username, ip));
                UpdatePlayerList();
            }
        }

        private void OnPlayerLeft(string username, string ip)
        {
            players.RemoveAll(p => p.ip == ip);
            UpdatePlayerList();
        }

        private void UpdatePlayerList()
        {
            if (clbxPlayers.InvokeRequired)
            {
                clbxPlayers.Invoke(new Action(UpdatePlayerList));
                return;
            }
            clbxPlayers.Items.Clear();
            foreach (var p in players)
                clbxPlayers.Items.Add($"{p.username} ({p.ip})");
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            // Seul l'host peut démarrer la partie
            if (HostJoin.server != null)
            {
                // L'host est le dessinateur au début
                HostJoin.server.Broadcast($"startGame::{HostJoin.myIp}<|EOM|>");
            }
        }

        private void OnStartGame(string ip)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(OnStartGame), ip);
                return;
            }
            Game game = new Game(ip);
            game.Show();
            this.Hide();
        }
    }
}
