using System.Windows.Forms;

namespace SkribbleIO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbxCanvas = new PictureBox();
            btnPen = new Button();
            btnEraser = new Button();
            trbWidth = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)pbxCanvas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbWidth).BeginInit();
            SuspendLayout();
            // 
            // pbxCanvas
            // 
            pbxCanvas.BackColor = Color.White;
            pbxCanvas.Image = (Image)resources.GetObject("pbxCanvas.Image");
            pbxCanvas.Location = new Point(174, 59);
            pbxCanvas.Name = "pbxCanvas";
            pbxCanvas.Size = new Size(880, 545);
            pbxCanvas.TabIndex = 0;
            pbxCanvas.TabStop = false;
            pbxCanvas.MouseDown += pbxCanvas_MouseDown;
            pbxCanvas.MouseMove += pbxCanvas_MouseMove;
            pbxCanvas.MouseUp += pbxCanvas_MouseUp;
            // 
            // btnPen
            // 
            btnPen.Location = new Point(1080, 105);
            btnPen.Name = "btnPen";
            btnPen.Size = new Size(91, 65);
            btnPen.TabIndex = 1;
            btnPen.Text = "crayon";
            btnPen.UseVisualStyleBackColor = true;
            btnPen.Click += btnPen_Click;
            // 
            // btnEraser
            // 
            btnEraser.Location = new Point(1080, 197);
            btnEraser.Name = "btnEraser";
            btnEraser.Size = new Size(91, 65);
            btnEraser.TabIndex = 2;
            btnEraser.Text = "gomme";
            btnEraser.UseVisualStyleBackColor = true;
            btnEraser.Click += btnEraser_Click;
            // 
            // trbWidth
            // 
            trbWidth.LargeChange = 10;
            trbWidth.Location = new Point(708, 623);
            trbWidth.Maximum = 150;
            trbWidth.Minimum = 5;
            trbWidth.Name = "trbWidth";
            trbWidth.Size = new Size(346, 45);
            trbWidth.SmallChange = 5;
            trbWidth.TabIndex = 4;
            trbWidth.Value = 5;
            trbWidth.Scroll += trbWidth_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(1244, 680);
            Controls.Add(trbWidth);
            Controls.Add(btnEraser);
            Controls.Add(btnPen);
            Controls.Add(pbxCanvas);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbxCanvas).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbWidth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxCanvas;
        private Button btnPen;
        private Button btnEraser;
        private TrackBar trbWidth;
    }
}
