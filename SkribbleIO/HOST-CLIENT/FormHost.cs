using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SkribbleIO.HOST_CLIENT
{
    public partial class FormHost : Game
    {
        Host hoster;
        public FormHost()
        {
            InitializeComponent();
            hoster = new Host();
            hoster.OnClientConnected += Host_OnClientConnected;
            hoster.OnClientDisconnected += Host_OnClientDisconnected;
        }
        private void Host_OnClientConnected(string clientInfo)
        {
            if (lb_f.InvokeRequired)
            {
                lb_f.Invoke(new Action(() => lb_f.Items.Add(clientInfo)));
            }
            else
            {
                lb_f.Items.Add(clientInfo);
            }
        }
        private void Host_OnClientDisconnected(string clientInfo)
        {
            if (lb_f.InvokeRequired)
            {
                lb_f.Invoke(new Action(() => lb_f.Items.Remove(clientInfo)));
            }
            else
            {
                lb_f.Items.Remove(clientInfo);
            }
        }
        //private void SendMessage()
        //{
        //    try
        //    {
        //        string message = tbx_msg.Text.Trim();
        //        if (string.IsNullOrEmpty(message)) return;

        //        string fullMessage = $"MSG:{Environment.MachineName}: {message}";
        //        byte[] data = Encoding.UTF8.GetBytes(fullMessage);
        //        udpClient.Send(data, data.Length, new IPEndPoint(IPAddress.Broadcast, Port));
        //        tbx_msg.Clear();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Erreur d'envoi : {ex.Message}");
        //    }
        //}
        private void btnStart_Click(object sender, EventArgs e)
        {
            hoster.OnMessageReceived += (msg) =>
            {
                Invoke(new Action(() => tbx_chat.AppendText(msg + "\n")));
            };
            hoster.Start(5050);
        }
    }
}
