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
    public partial class HostJoin : Form
    {
        Host hoster;
        public HostJoin()
        {
            InitializeComponent();
            hoster = new Host();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Lobby lobbyForm = new Lobby();
            lobbyForm.Show();
            hoster.Start(5050);
            this.Hide();
        }
    }
}
