using System.Windows.Forms;

namespace SkribbleIO
{
    partial class Game
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            pbxCanvas = new PictureBox();
            trbWidth = new TrackBar();
            btnSendMessage = new Button();
            lbxChat = new ListBox();
            lbxPlayer = new ListBox();
            lblSecretWord = new Label();
            lblClock = new Label();
            btnEraser = new Button();
            btnRed = new Button();
            btnBlack = new Button();
            btnBlue = new Button();
            btnGreen = new Button();
            btnMagenta = new Button();
            btnGold = new Button();
            tbxMessage = new TextBox();
            tmrClock = new System.Windows.Forms.Timer(components);
            btnPen = new Button();
            btnCyan = new Button();
            pnlWidthIcon3 = new Panel();
            pnlWidthIcon2 = new Panel();
            pnlWidthIcon1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbxCanvas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbWidth).BeginInit();
            SuspendLayout();
            // 
            // pbxCanvas
            // 
            pbxCanvas.BackColor = Color.White;
            pbxCanvas.Image = (Image)resources.GetObject("pbxCanvas.Image");
            pbxCanvas.Location = new Point(205, 59);
            pbxCanvas.Name = "pbxCanvas";
            pbxCanvas.Size = new Size(880, 545);
            pbxCanvas.TabIndex = 0;
            pbxCanvas.TabStop = false;
            pbxCanvas.MouseDown += pbxCanvas_MouseDown;
            pbxCanvas.MouseMove += pbxCanvas_MouseMove;
            pbxCanvas.MouseUp += pbxCanvas_MouseUp;
            // 
            // trbWidth
            // 
            trbWidth.Cursor = Cursors.NoMoveHoriz;
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
            // btnSendMessage
            // 
            btnSendMessage.Location = new Point(1091, 637);
            btnSendMessage.Name = "btnSendMessage";
            btnSendMessage.Size = new Size(189, 26);
            btnSendMessage.TabIndex = 0;
            btnSendMessage.UseVisualStyleBackColor = true;
            // 
            // lbxChat
            // 
            lbxChat.FormattingEnabled = true;
            lbxChat.ItemHeight = 15;
            lbxChat.Location = new Point(1091, 59);
            lbxChat.Name = "lbxChat";
            lbxChat.Size = new Size(189, 544);
            lbxChat.TabIndex = 1;
            // 
            // lbxPlayer
            // 
            lbxPlayer.FormattingEnabled = true;
            lbxPlayer.ItemHeight = 15;
            lbxPlayer.Location = new Point(12, 59);
            lbxPlayer.Name = "lbxPlayer";
            lbxPlayer.Size = new Size(189, 544);
            lbxPlayer.TabIndex = 2;
            // 
            // lblSecretWord
            // 
            lblSecretWord.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSecretWord.Location = new Point(362, 9);
            lblSecretWord.Name = "lblSecretWord";
            lblSecretWord.Size = new Size(532, 44);
            lblSecretWord.TabIndex = 3;
            // 
            // lblClock
            // 
            lblClock.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClock.Location = new Point(12, 9);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(189, 44);
            lblClock.TabIndex = 4;
            // 
            // btnEraser
            // 
            btnEraser.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEraser.ForeColor = Color.Black;
            btnEraser.Location = new Point(301, 610);
            btnEraser.Name = "btnEraser";
            btnEraser.Size = new Size(54, 53);
            btnEraser.TabIndex = 17;
            btnEraser.Text = "\U0001f9fd";
            btnEraser.UseVisualStyleBackColor = true;
            btnEraser.Click += btnEraser_Click;
            // 
            // btnRed
            // 
            btnRed.BackColor = Color.Red;
            btnRed.FlatAppearance.BorderColor = Color.FromArgb(74, 152, 211);
            btnRed.FlatAppearance.BorderSize = 0;
            btnRed.FlatStyle = FlatStyle.Flat;
            btnRed.Location = new Point(410, 610);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(35, 28);
            btnRed.TabIndex = 8;
            btnRed.UseVisualStyleBackColor = false;
            btnRed.Click += btnRed_Click;
            // 
            // btnBlack
            // 
            btnBlack.BackColor = Color.Black;
            btnBlack.FlatAppearance.BorderColor = Color.FromArgb(74, 152, 211);
            btnBlack.FlatAppearance.BorderSize = 3;
            btnBlack.FlatStyle = FlatStyle.Flat;
            btnBlack.Location = new Point(369, 610);
            btnBlack.Name = "btnBlack";
            btnBlack.Size = new Size(35, 28);
            btnBlack.TabIndex = 9;
            btnBlack.UseVisualStyleBackColor = false;
            btnBlack.Click += btnBlack_Click;
            // 
            // btnBlue
            // 
            btnBlue.BackColor = Color.Blue;
            btnBlue.FlatAppearance.BorderColor = Color.FromArgb(74, 152, 211);
            btnBlue.FlatAppearance.BorderSize = 0;
            btnBlue.FlatStyle = FlatStyle.Flat;
            btnBlue.ForeColor = Color.Black;
            btnBlue.Location = new Point(451, 610);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(35, 28);
            btnBlue.TabIndex = 10;
            btnBlue.UseVisualStyleBackColor = false;
            btnBlue.Click += btnBlue_Click;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.Green;
            btnGreen.FlatAppearance.BorderColor = Color.FromArgb(74, 152, 211);
            btnGreen.FlatAppearance.BorderSize = 0;
            btnGreen.FlatStyle = FlatStyle.Flat;
            btnGreen.ForeColor = Color.Black;
            btnGreen.Location = new Point(492, 610);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(35, 28);
            btnGreen.TabIndex = 11;
            btnGreen.UseVisualStyleBackColor = false;
            btnGreen.Click += btnGreen_Click;
            // 
            // btnMagenta
            // 
            btnMagenta.BackColor = Color.Magenta;
            btnMagenta.FlatAppearance.BorderColor = Color.FromArgb(74, 152, 211);
            btnMagenta.FlatAppearance.BorderSize = 0;
            btnMagenta.FlatStyle = FlatStyle.Flat;
            btnMagenta.ForeColor = Color.Black;
            btnMagenta.Location = new Point(574, 610);
            btnMagenta.Name = "btnMagenta";
            btnMagenta.Size = new Size(35, 28);
            btnMagenta.TabIndex = 13;
            btnMagenta.UseVisualStyleBackColor = false;
            btnMagenta.Click += btnMagenta_Click;
            // 
            // btnGold
            // 
            btnGold.BackColor = Color.Gold;
            btnGold.FlatAppearance.BorderColor = Color.FromArgb(74, 152, 211);
            btnGold.FlatAppearance.BorderSize = 0;
            btnGold.FlatStyle = FlatStyle.Flat;
            btnGold.ForeColor = Color.Black;
            btnGold.Location = new Point(533, 610);
            btnGold.Name = "btnGold";
            btnGold.Size = new Size(35, 28);
            btnGold.TabIndex = 14;
            btnGold.UseVisualStyleBackColor = false;
            btnGold.Click += btnGold_Click;
            // 
            // tbxMessage
            // 
            tbxMessage.Location = new Point(1091, 607);
            tbxMessage.Name = "tbxMessage";
            tbxMessage.Size = new Size(189, 23);
            tbxMessage.TabIndex = 15;
            // 
            // tmrClock
            // 
            tmrClock.Interval = 1000;
            tmrClock.Tick += tmrClock_Tick;
            // 
            // btnPen
            // 
            btnPen.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPen.Location = new Point(243, 610);
            btnPen.Name = "btnPen";
            btnPen.Size = new Size(54, 53);
            btnPen.TabIndex = 16;
            btnPen.Text = "🖍";
            btnPen.UseVisualStyleBackColor = true;
            btnPen.Click += btnPen_Click;
            // 
            // btnCyan
            // 
            btnCyan.BackColor = Color.Cyan;
            btnCyan.FlatAppearance.BorderColor = Color.FromArgb(74, 152, 211);
            btnCyan.FlatAppearance.BorderSize = 0;
            btnCyan.FlatStyle = FlatStyle.Flat;
            btnCyan.ForeColor = Color.Black;
            btnCyan.Location = new Point(615, 610);
            btnCyan.Name = "btnCyan";
            btnCyan.Size = new Size(35, 28);
            btnCyan.TabIndex = 18;
            btnCyan.UseVisualStyleBackColor = false;
            btnCyan.Click += btnCyan_Click;
            // 
            // pnlWidthIcon3
            // 
            pnlWidthIcon3.BackColor = Color.Black;
            pnlWidthIcon3.Location = new Point(679, 643);
            pnlWidthIcon3.Name = "pnlWidthIcon3";
            pnlWidthIcon3.Size = new Size(30, 10);
            pnlWidthIcon3.TabIndex = 19;
            // 
            // pnlWidthIcon2
            // 
            pnlWidthIcon2.BackColor = Color.Black;
            pnlWidthIcon2.Location = new Point(679, 632);
            pnlWidthIcon2.Name = "pnlWidthIcon2";
            pnlWidthIcon2.Size = new Size(30, 5);
            pnlWidthIcon2.TabIndex = 20;
            // 
            // pnlWidthIcon1
            // 
            pnlWidthIcon1.BackColor = Color.Black;
            pnlWidthIcon1.Location = new Point(679, 624);
            pnlWidthIcon1.Name = "pnlWidthIcon1";
            pnlWidthIcon1.Size = new Size(30, 3);
            pnlWidthIcon1.TabIndex = 21;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1304, 672);
            Controls.Add(pnlWidthIcon1);
            Controls.Add(pnlWidthIcon2);
            Controls.Add(pnlWidthIcon3);
            Controls.Add(btnCyan);
            Controls.Add(btnPen);
            Controls.Add(trbWidth);
            Controls.Add(pbxCanvas);
            Controls.Add(tbxMessage);
            Controls.Add(btnGold);
            Controls.Add(btnMagenta);
            Controls.Add(btnGreen);
            Controls.Add(btnBlue);
            Controls.Add(btnBlack);
            Controls.Add(btnRed);
            Controls.Add(btnEraser);
            Controls.Add(lblClock);
            Controls.Add(lblSecretWord);
            Controls.Add(lbxPlayer);
            Controls.Add(lbxChat);
            Controls.Add(btnSendMessage);
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbxCanvas).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbWidth).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbxCanvas;
        private TrackBar trbWidth;
        private Button btnSendMessage;
        private ListBox lbxChat;
        private ListBox lbxPlayer;
        private Label lblSecretWord;
        private Label lblClock;
 
        private Button btnEraser;
        private Button btnRed;
        private Button btnBlack;
        private Button btnBlue;
        private Button btnGreen;
        private Button btnMagenta;
        private Button btnGold;
        private TextBox tbxMessage;
        private System.Windows.Forms.Timer tmrClock;
        private Button btnPen;
        private Button btnCyan;
        private Panel pnlWidthIcon3;
        private Panel pnlWidthIcon2;
        private Panel pnlWidthIcon1;
    }
}
