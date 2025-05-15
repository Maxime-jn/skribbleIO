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
            txtChat = new TextBox();
            lb_drawTime = new ListBox();
            imageList1 = new ImageList(components);
            lb_rounds = new ListBox();
            nb_mots = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnStart = new Button();
            lbl_Connected = new Label();
            lb_f = new ListBox();
            SuspendLayout();
            // 
            // txtChat
            // 
            txtChat.Location = new Point(12, 186);
            txtChat.Multiline = true;
            txtChat.Name = "txtChat";
            txtChat.Size = new Size(499, 77);
            txtChat.TabIndex = 0;
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
            // nb_mots
            // 
            nb_mots.FormattingEnabled = true;
            nb_mots.ItemHeight = 15;
            nb_mots.Location = new Point(173, 80);
            nb_mots.Name = "nb_mots";
            nb_mots.Size = new Size(189, 19);
            nb_mots.TabIndex = 3;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 84);
            label3.Name = "label3";
            label3.Size = new Size(146, 15);
            label3.TabIndex = 7;
            label3.Text = "nombre de mots proposés";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 168);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 8;
            label4.Text = "Mots Personalisés";
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
            lbl_Connected.Size = new Size(101, 15);
            lbl_Connected.TabIndex = 10;
            lbl_Connected.Text = "Mots Personalisés";
            // 
            // lb_f
            // 
            lb_f.FormattingEnabled = true;
            lb_f.ItemHeight = 15;
            lb_f.Location = new Point(17, 298);
            lb_f.Name = "lb_f";
            lb_f.Size = new Size(494, 79);
            lb_f.TabIndex = 11;
            // 
            // FormHost
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 423);
            Controls.Add(lb_f);
            Controls.Add(lbl_Connected);
            Controls.Add(btnStart);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nb_mots);
            Controls.Add(lb_rounds);
            Controls.Add(lb_drawTime);
            Controls.Add(txtChat);
            Name = "FormHost";
            Text = "FormHost";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtChat;
        private ListBox lb_drawTime;
        private ImageList imageList1;
        private ListBox lb_rounds;
        private ListBox nb_mots;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnStart;
        private Label lbl_Connected;
        private ListBox lb_f;
    }
}