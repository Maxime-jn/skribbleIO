using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkribbleIO;

namespace SkribbleIO
{
    public partial class Lobby : Form
    {
        Host hoster;
        public Lobby()
        {
            InitializeComponent();
            hoster = new Host();
            hoster.OnClientConnected += Host_OnClientConnected;
            hoster.OnClientDisconnected += Host_OnClientDisconnected;
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
        private void lobby_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
            this.Hide();
        }
    }
}
