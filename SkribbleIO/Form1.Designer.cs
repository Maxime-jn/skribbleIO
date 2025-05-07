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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pbxCanvas = new PictureBox();
            trbWidth = new TrackBar();
            btnSendMessage = new Button();
            lbxChat = new ListBox();
            lbxPlayer = new ListBox();
            lblSecretWord = new Label();
            lblClock = new Label();
            btnRed = new Button();
            btnBlack = new Button();
            btnBlue = new Button();
            btnGreen = new Button();
            btnRose = new Button();
            btnYellow = new Button();
            tbxMessage = new TextBox();
            tmrClock = new System.Windows.Forms.Timer(components);
            btnPen = new Button();
            btnEraser = new Button();
            btnCyan = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxCanvas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbWidth).BeginInit();
            SuspendLayout();
            // 
            // pbxCanvas
            // 
            pbxCanvas.BackColor = Color.White;
            pbxCanvas.Image = (Image)resources.GetObject("pbxCanvas.Image");
            pbxCanvas.Location = new Point(205, 58);
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
            lblClock.Text = "label2";
            // 
            // btnRed
            // 
            btnRed.BackColor = Color.Red;
            btnRed.FlatAppearance.BorderColor = Color.FromArgb(74, 152, 211);
            btnRed.FlatAppearance.BorderSize = 3;
            btnRed.FlatStyle = FlatStyle.Flat;
            btnRed.Location = new Point(410, 610);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(35, 28);
            btnRed.TabIndex = 8;
            btnRed.UseVisualStyleBackColor = false;
            // 
            // btnBlack
            // 
            btnBlack.BackColor = Color.Black;
            btnBlack.FlatStyle = FlatStyle.Flat;
            btnBlack.Location = new Point(369, 610);
            btnBlack.Name = "btnBlack";
            btnBlack.Size = new Size(35, 28);
            btnBlack.TabIndex = 9;
            btnBlack.UseVisualStyleBackColor = false;
            // 
            // btnBlue
            // 
            btnBlue.BackColor = Color.Blue;
            btnBlue.FlatStyle = FlatStyle.Flat;
            btnBlue.ForeColor = Color.FromArgb(19, 63, 140);
            btnBlue.Location = new Point(451, 610);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(35, 28);
            btnBlue.TabIndex = 10;
            btnBlue.UseVisualStyleBackColor = false;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.Green;
            btnGreen.FlatStyle = FlatStyle.Flat;
            btnGreen.ForeColor = Color.FromArgb(19, 63, 140);
            btnGreen.Location = new Point(492, 610);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(35, 28);
            btnGreen.TabIndex = 11;
            btnGreen.UseVisualStyleBackColor = false;
            // 
            // btnRose
            // 
            btnRose.BackColor = Color.Magenta;
            btnRose.FlatStyle = FlatStyle.Flat;
            btnRose.ForeColor = Color.FromArgb(19, 63, 140);
            btnRose.Location = new Point(574, 610);
            btnRose.Name = "btnRose";
            btnRose.Size = new Size(35, 28);
            btnRose.TabIndex = 13;
            btnRose.UseVisualStyleBackColor = false;
            // 
            // btnYellow
            // 
            btnYellow.BackColor = Color.Yellow;
            btnYellow.FlatStyle = FlatStyle.Flat;
            btnYellow.ForeColor = Color.FromArgb(19, 63, 140);
            btnYellow.Location = new Point(533, 610);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(35, 28);
            btnYellow.TabIndex = 14;
            btnYellow.UseVisualStyleBackColor = false;
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
            // 
            // btnPen
            // 
            btnPen.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPen.Location = new Point(246, 610);
            btnPen.Name = "btnPen";
            btnPen.Size = new Size(57, 53);
            btnPen.TabIndex = 16;
            btnPen.Text = "🖍";
            btnPen.UseVisualStyleBackColor = true;
            btnPen.Click += btnPen_Click;
            // 
            // btnEraser
            // 
            btnEraser.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEraser.Location = new Point(306, 610);
            btnEraser.Name = "btnEraser";
            btnEraser.Size = new Size(57, 53);
            btnEraser.TabIndex = 17;
            btnEraser.Text = "\U0001f9fd";
            btnEraser.UseVisualStyleBackColor = true;
            btnEraser.Click += btnEraser_Click;
            // 
            // btnCyan
            // 
            btnCyan.BackColor = Color.Cyan;
            btnCyan.FlatStyle = FlatStyle.Flat;
            btnCyan.ForeColor = Color.FromArgb(19, 63, 140);
            btnCyan.Location = new Point(615, 610);
            btnCyan.Name = "btnCyan";
            btnCyan.Size = new Size(35, 28);
            btnCyan.TabIndex = 18;
            btnCyan.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 63, 140);
            ClientSize = new Size(1304, 672);
            Controls.Add(btnCyan);
            Controls.Add(btnEraser);
            Controls.Add(btnPen);
            Controls.Add(trbWidth);
            Controls.Add(pbxCanvas);
            Controls.Add(tbxMessage);
            Controls.Add(btnYellow);
            Controls.Add(btnRose);
            Controls.Add(btnGreen);
            Controls.Add(btnBlue);
            Controls.Add(btnBlack);
            Controls.Add(btnRed);
            Controls.Add(lblClock);
            Controls.Add(lblSecretWord);
            Controls.Add(lbxPlayer);
            Controls.Add(lbxChat);
            Controls.Add(btnSendMessage);
            Name = "Form1";
            Text = "C# Skribbl.io";
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
        private Button btnRed;
        private Button btnBlack;
        private Button btnBlue;
        private Button btnGreen;
        private Button btnRose;
        private Button btnYellow;
        private TextBox tbxMessage;
        private System.Windows.Forms.Timer tmrClock;
        private Button btnPen;
        private Button btnEraser;
        private Button btnCyan;
    }
}
