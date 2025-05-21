using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkribbleIO.HOST_CLIENT
{
    public partial class FormHost : Game
    {
        Host hoster;
        public FormHost()
        {
            InitializeComponent();
            hoster = new Host();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            hoster.OnMessageReceived += (msg) =>
            {
                Invoke(new Action(() => txtChat.AppendText(">>" + msg + "\n")));
            };
            hoster.Start(5050);
        }
    }
}
