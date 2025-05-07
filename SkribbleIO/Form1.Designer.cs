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
            btnSendMessage = new Button();
            lbxChat = new ListBox();
            lbxPlayer = new ListBox();
            lblSecretWord = new Label();
            lblClock = new Label();
            pbxCanva = new PictureBox();
            btnPen = new Button();
            btnEraser = new Button();
            btnRed = new Button();
            btnBlack = new Button();
            btnBlue = new Button();
            btnGreen = new Button();
            btnRose = new Button();
            btnYellow = new Button();
            tbxMessage = new TextBox();
            tmrClock = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbxCanva).BeginInit();
            SuspendLayout();
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
            // pbxCanva
            // 
            pbxCanva.Location = new Point(207, 59);
            pbxCanva.Name = "pbxCanva";
            pbxCanva.Size = new Size(880, 545);
            pbxCanva.TabIndex = 5;
            pbxCanva.TabStop = false;
            // 
            // btnPen
            // 
            btnPen.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPen.Location = new Point(207, 610);
            btnPen.Name = "btnPen";
            btnPen.Size = new Size(75, 53);
            btnPen.TabIndex = 6;
            btnPen.Text = "🖊️";
            btnPen.UseVisualStyleBackColor = true;
            // 
            // btnEraser
            // 
            btnEraser.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEraser.ForeColor = Color.Black;
            btnEraser.Location = new Point(288, 610);
            btnEraser.Name = "btnEraser";
            btnEraser.Size = new Size(75, 53);
            btnEraser.TabIndex = 7;
            btnEraser.Text = "\U0001f9fd";
            btnEraser.UseVisualStyleBackColor = true;
            // 
            // btnRed
            // 
            btnRed.BackColor = Color.Red;
            btnRed.ForeColor = Color.Red;
            btnRed.Location = new Point(369, 610);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(35, 28);
            btnRed.TabIndex = 8;
            btnRed.UseVisualStyleBackColor = false;
            // 
            // btnBlack
            // 
            btnBlack.BackColor = Color.Black;
            btnBlack.Location = new Point(410, 610);
            btnBlack.Name = "btnBlack";
            btnBlack.Size = new Size(35, 28);
            btnBlack.TabIndex = 9;
            btnBlack.UseVisualStyleBackColor = false;
            // 
            // btnBlue
            // 
            btnBlue.BackColor = Color.Blue;
            btnBlue.Location = new Point(451, 610);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(35, 28);
            btnBlue.TabIndex = 10;
            btnBlue.UseVisualStyleBackColor = false;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.Green;
            btnGreen.Location = new Point(492, 610);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(35, 28);
            btnGreen.TabIndex = 11;
            btnGreen.UseVisualStyleBackColor = false;
            // 
            // btnRose
            // 
            btnRose.BackColor = Color.Magenta;
            btnRose.Location = new Point(574, 610);
            btnRose.Name = "btnRose";
            btnRose.Size = new Size(35, 28);
            btnRose.TabIndex = 13;
            btnRose.UseVisualStyleBackColor = false;
            // 
            // btnYellow
            // 
            btnYellow.BackColor = Color.Yellow;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 672);
            Controls.Add(tbxMessage);
            Controls.Add(btnYellow);
            Controls.Add(btnRose);
            Controls.Add(btnGreen);
            Controls.Add(btnBlue);
            Controls.Add(btnBlack);
            Controls.Add(btnRed);
            Controls.Add(btnEraser);
            Controls.Add(btnPen);
            Controls.Add(pbxCanva);
            Controls.Add(lblClock);
            Controls.Add(lblSecretWord);
            Controls.Add(lbxPlayer);
            Controls.Add(lbxChat);
            Controls.Add(btnSendMessage);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pbxCanva).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSendMessage;
        private ListBox lbxChat;
        private ListBox lbxPlayer;
        private Label lblSecretWord;
        private Label lblClock;
        private PictureBox pbxCanva;
        private Button btnPen;
        private Button btnEraser;
        private Button btnRed;
        private Button btnBlack;
        private Button btnBlue;
        private Button btnGreen;
        private Button btnRose;
        private Button btnYellow;
        private TextBox tbxMessage;
        private System.Windows.Forms.Timer tmrClock;
    }
}
