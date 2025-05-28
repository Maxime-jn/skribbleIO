namespace SkribbleIO
{
    partial class Lobby
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
            btnStart = new Button();
            clbxPlayers = new CheckedListBox();
            lblLobby = new Label();
            lbl_ip = new Label();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(653, 299);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(135, 124);
            btnStart.TabIndex = 0;
            btnStart.Text = "Commencer la partie";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // clbxPlayers
            // 
            clbxPlayers.FormattingEnabled = true;
            clbxPlayers.Location = new Point(12, 77);
            clbxPlayers.Name = "clbxPlayers";
            clbxPlayers.Size = new Size(635, 346);
            clbxPlayers.TabIndex = 1;
            // 
            // lblLobby
            // 
            lblLobby.AutoSize = true;
            lblLobby.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLobby.Location = new Point(12, 24);
            lblLobby.Name = "lblLobby";
            lblLobby.Size = new Size(87, 32);
            lblLobby.TabIndex = 2;
            lblLobby.Text = "LOBBY";
            // 
            // lbl_ip
            // 
            lbl_ip.AutoSize = true;
            lbl_ip.Location = new Point(565, 31);
            lbl_ip.Name = "lbl_ip";
            lbl_ip.Size = new Size(38, 15);
            lbl_ip.TabIndex = 3;
            lbl_ip.Text = "label1";
            // 
            // Lobby
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_ip);
            Controls.Add(lblLobby);
            Controls.Add(clbxPlayers);
            Controls.Add(btnStart);
            Name = "Lobby";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "lobby";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private CheckedListBox clbxPlayers;
        private Label lblLobby;
        private Label lbl_ip;
    }
}