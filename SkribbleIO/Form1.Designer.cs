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
            button1 = new Button();
            lbxChat = new ListBox();
            lbxPlayer = new ListBox();
            label1 = new Label();
            lblClock = new Label();
            pbxCanva = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button9 = new Button();
            button10 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxCanva).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(1091, 620);
            button1.Name = "button1";
            button1.Size = new Size(189, 40);
            button1.TabIndex = 0;
            button1.Text = "btnSendMessage";
            button1.UseVisualStyleBackColor = true;
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
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(362, 9);
            label1.Name = "label1";
            label1.Size = new Size(532, 44);
            label1.TabIndex = 3;
            label1.Text = "lblSecretWord";
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
            // button2
            // 
            button2.Location = new Point(207, 610);
            button2.Name = "button2";
            button2.Size = new Size(75, 53);
            button2.TabIndex = 6;
            button2.Text = "ptnPen";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(288, 610);
            button3.Name = "button3";
            button3.Size = new Size(75, 53);
            button3.TabIndex = 7;
            button3.Text = "btnEraser";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(369, 610);
            button4.Name = "button4";
            button4.Size = new Size(35, 28);
            button4.TabIndex = 8;
            button4.Text = "btnRed";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(410, 610);
            button5.Name = "button5";
            button5.Size = new Size(35, 28);
            button5.TabIndex = 9;
            button5.Text = "btnBlack";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(451, 610);
            button6.Name = "button6";
            button6.Size = new Size(35, 28);
            button6.TabIndex = 10;
            button6.Text = "btnBlue";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(492, 610);
            button7.Name = "button7";
            button7.Size = new Size(35, 28);
            button7.TabIndex = 11;
            button7.Text = "btnGreen";
            button7.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(574, 610);
            button9.Name = "button9";
            button9.Size = new Size(35, 28);
            button9.TabIndex = 13;
            button9.Text = "btnRose";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(533, 610);
            button10.Name = "button10";
            button10.Size = new Size(35, 28);
            button10.TabIndex = 14;
            button10.Text = "btnYellow";
            button10.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1304, 672);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pbxCanva);
            Controls.Add(lblClock);
            Controls.Add(label1);
            Controls.Add(lbxPlayer);
            Controls.Add(lbxChat);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pbxCanva).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ListBox lbxChat;
        private ListBox lbxPlayer;
        private Label label1;
        private Label lblClock;
        private PictureBox pbxCanva;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button9;
        private Button button10;
    }
}
