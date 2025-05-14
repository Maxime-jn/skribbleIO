using System.Drawing.Imaging;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SkribbleIO
{
    public partial class Form1 : Form
    {
        private int port = 5000;
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        private Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();
            beginConnection();
        }

        private void beginConnection()
        {
            receiveThread = new Thread(receiveTable)
            {
                IsBackground = true
            };
            receiveThread.Start();
        }

        private void sendTable()
        {

        }

        private void receiveTable()
        {
            TcpListener server = new TcpListener(IPAddress.Any, port);
            server.Start();

            TcpClient client = server.AcceptTcpClient();

            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);

            string messageRecu = Encoding.UTF8.GetString(buffer, 0, bytesRead);
        }

        private void sendChooseWord()
        {

        }

        private void receiveChooseWord()
        {
            
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    } 
}

