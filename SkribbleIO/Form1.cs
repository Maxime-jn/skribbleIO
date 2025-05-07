using System.Windows.Forms;

namespace SkribbleIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isDrawing = false;
        private Point lastPoint = Point.Empty;
        private Color selectedColor = Color.Black;
        private int selectedWidth = 5;
        private void pbxCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && pbxCanvas.Image != null)
            {
                Bitmap bmp = (Bitmap)pbxCanvas.Image;
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    using (Pen p = new Pen(selectedColor, selectedWidth))
                    using (Brush b = new SolidBrush(selectedColor))
                    {
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        g.DrawLine(p, lastPoint, e.Location);

                        // Remplit les trous entre les points en dessinant un petit cercle à l'arrivée
                        int radius = selectedWidth / 2; // rayon du cercle (à ajuster selon l'épaisseur)
                        g.FillEllipse(b, e.X - radius, e.Y - radius, radius * 2, radius * 2);
                    }
                }

                pbxCanvas.Invalidate();
                lastPoint = e.Location;
            }
        }
        private void pbxCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            // Handle mouse down event
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                lastPoint = e.Location;
            }
        }

        private void pbxCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            // Handle mouse up event
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
            }
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            selectedColor = Color.Black;
        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            selectedColor = Color.White; // Utilise la couleur de fond pour effacer

        }

        private void trbWidth_Scroll(object sender, EventArgs e)
        {
            selectedWidth = trbWidth.Value;
        }
    }
}
