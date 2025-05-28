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

            Lobby lobbyForm = new Lobby(hoster); // Pass host instance to Lobby
            lobbyForm.Show();
            hoster.Start();
            this.Hide();
        }
    }
}
