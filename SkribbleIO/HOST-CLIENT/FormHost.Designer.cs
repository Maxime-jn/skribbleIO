namespace SkribbleIO.HOST_CLIENT
{
    partial class FormHost
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tbx_MotPerso = new TextBox();
            lb_drawTime = new ListBox();
            imageList1 = new ImageList(components);
            lb_rounds = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            btnStart = new Button();
            lbl_Connected = new Label();
            lb_f = new ListBox();
            tbx_chat = new TextBox();
            label3 = new Label();
            tbx_msg = new TextBox();
            btnSend = new Button();
            SuspendLayout();
            // 
            // tbx_MotPerso
            // 
            tbx_MotPerso.Location = new Point(12, 186);
            tbx_MotPerso.Multiline = true;
            tbx_MotPerso.Name = "tbx_MotPerso";
            tbx_MotPerso.Size = new Size(499, 77);
            tbx_MotPerso.TabIndex = 0;
            // 
            // lb_drawTime
            // 
            lb_drawTime.FormattingEnabled = true;
            lb_drawTime.ItemHeight = 15;
            lb_drawTime.Location = new Point(173, 30);
            lb_drawTime.Name = "lb_drawTime";
            lb_drawTime.Size = new Size(189, 19);
            lb_drawTime.TabIndex = 1;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // lb_rounds
            // 
            lb_rounds.FormattingEnabled = true;
            lb_rounds.ItemHeight = 15;
            lb_rounds.Location = new Point(173, 55);
            lb_rounds.Name = "lb_rounds";
            lb_rounds.Size = new Size(189, 19);
            lb_rounds.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 34);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "DrawTime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 59);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 6;
            label2.Text = "Rounds";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(298, 15);
            label4.TabIndex = 8;
            label4.Text = "Mots Personalisés (veulliez séparer les mots par une \",\")";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(14, 382);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(497, 29);
            btnStart.TabIndex = 9;
            btnStart.Text = "Start!";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lbl_Connected
            // 
            lbl_Connected.AutoSize = true;
            lbl_Connected.Location = new Point(14, 277);
            lbl_Connected.Name = "lbl_Connected";
            lbl_Connected.Size = new Size(47, 15);
            lbl_Connected.TabIndex = 10;
            lbl_Connected.Text = "Joueurs";
            // 
            // lb_f
            // 
            lb_f.FormattingEnabled = true;
            lb_f.ItemHeight = 15;
            lb_f.Location = new Point(14, 295);
            lb_f.Name = "lb_f";
            lb_f.Size = new Size(497, 79);
            lb_f.TabIndex = 11;
            // 
            // tbx_chat
            // 
            tbx_chat.Location = new Point(520, 30);
            tbx_chat.Multiline = true;
            tbx_chat.Name = "tbx_chat";
            tbx_chat.Size = new Size(200, 299);
            tbx_chat.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(520, 9);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 13;
            label3.Text = "Tchat";
            // 
            // tbx_msg
            // 
            tbx_msg.Location = new Point(520, 335);
            tbx_msg.Multiline = true;
            tbx_msg.Name = "tbx_msg";
            tbx_msg.Size = new Size(200, 41);
            tbx_msg.TabIndex = 14;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(520, 382);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(200, 29);
            btnSend.TabIndex = 15;
            btnSend.Text = "Envoyer";
            btnSend.UseVisualStyleBackColor = true;
            // 
            // FormHost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(732, 423);
            Controls.Add(btnSend);
            Controls.Add(tbx_msg);
            Controls.Add(label3);
            Controls.Add(tbx_chat);
            Controls.Add(lb_f);
            Controls.Add(lbl_Connected);
            Controls.Add(btnStart);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lb_rounds);
            Controls.Add(lb_drawTime);
            Controls.Add(tbx_MotPerso);
            Name = "FormHost";
            Text = "FormHost";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbx_MotPerso;
        private ListBox lb_drawTime;
        private ImageList imageList1;
        private ListBox lb_rounds;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button btnStart;
        private Label lbl_Connected;
        private ListBox lb_f;
        private TextBox tbx_chat;
        private Label label3;
        private TextBox tbx_msg;
        private Button btnSend;
    }
}