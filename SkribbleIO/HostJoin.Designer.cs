namespace SkribbleIO
{
    partial class HostJoin
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
            btnCreate = new Button();
            btnJoin = new Button();
            lblIpHost = new Label();
            tbxIpHost = new TextBox();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(306, 63);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(150, 109);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Crée la partie";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnJoin
            // 
            btnJoin.Location = new Point(306, 204);
            btnJoin.Name = "btnJoin";
            btnJoin.Size = new Size(150, 109);
            btnJoin.TabIndex = 1;
            btnJoin.Text = "Rejoindre une partie";
            btnJoin.UseVisualStyleBackColor = true;
            // 
            // lblIpHost
            // 
            lblIpHost.AutoSize = true;
            lblIpHost.Location = new Point(324, 325);
            lblIpHost.Name = "lblIpHost";
            lblIpHost.Size = new Size(110, 15);
            lblIpHost.TabIndex = 2;
            lblIpHost.Text = "Mettez l'ip de l'host";
            // 
            // tbxIpHost
            // 
            tbxIpHost.Location = new Point(310, 343);
            tbxIpHost.Name = "tbxIpHost";
            tbxIpHost.Size = new Size(146, 23);
            tbxIpHost.TabIndex = 3;
            // 
            // HostJoin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbxIpHost);
            Controls.Add(lblIpHost);
            Controls.Add(btnJoin);
            Controls.Add(btnCreate);
            Name = "HostJoin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HostJoin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Button btnJoin;
        private Label lblIpHost;
        private TextBox tbxIpHost;
    }
}