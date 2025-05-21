using System.Net;
using System.Net.Sockets;
using System.Text;
/**
 * https://learn.microsoft.com/en-us/dotnet/api/system.drawing.bitmap?view=windowsdesktop-9.0
 * https://learn.microsoft.com/en-us/dotnet/api/system.net.sockets.tcpclient?view=net-9.0
 */
namespace SkribbleIO
{
    public partial class Game : Form
    {
        private int port = 5050;
        private TcpClient client;
        private NetworkStream stream;
        private Thread receiveThread;
        private Bitmap bitmap;

        public Game()
        {
            InitializeComponent();
            StartReceivingFromHost("10.5.43.40", port);
            SendGuess("Slt", "10.5.43.40", port);
        }

        private void StartReceivingFromHost(string hostIp, int port)
        {
            client = new TcpClient(hostIp, port);
            stream = client.GetStream();

            Thread  receiveThread = new Thread(() =>
            {
                while (true)
                {
                    try
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            byte[] buffer = new byte[1024];
                            int bytesRead;

                            // Lit tant que des données arrivent
                            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                ms.Write(buffer, 0, bytesRead);
                                // Ajoute une pause ou logique pour détecter fin d'image
                                if (bytesRead < buffer.Length)
                                    break;
                            }

                            //if (ms.Length > 0)
                            //{
                            //    Bitmap image = new Bitmap(ms);
                            //    Invoke((MethodInvoker)(() =>
                            //    {
                                    label1.Text = "Connecter";
                            //        pictureBox1.Image = image; // affiche le dessin reçu
                            //    }));
                            //}
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Erreur réception : " + ex.Message);
                        break;
                    }
                }
            });

            receiveThread.IsBackground = true;
            receiveThread.Start();
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

        private void SendGuess(string guess, string hostIp, int port)
        {
            try
            {
                TcpClient guessClient = new TcpClient(hostIp, port);
                NetworkStream stream = guessClient.GetStream();

                byte[] guessBytes = Encoding.UTF8.GetBytes(guess);
                stream.Write(guessBytes, 0, guessBytes.Length);
                guessClient.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur envoi guess : " + ex.Message);
            }
        }


        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
    }
}

