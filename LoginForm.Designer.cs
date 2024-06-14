namespace scoreBill
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            LoginBox1 = new TextBox();
            PasswordBox1 = new TextBox();
            LoginLabel = new Label();
            signInBtn = new Button();
            espegicLogo = new PictureBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            helpProvider1 = new HelpProvider();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)espegicLogo).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // LoginBox1
            // 
            LoginBox1.AccessibleDescription = "";
            LoginBox1.AccessibleName = "login";
            LoginBox1.Anchor = AnchorStyles.None;
            LoginBox1.Location = new Point(218, 304);
            LoginBox1.Margin = new Padding(4);
            LoginBox1.Name = "LoginBox1";
            LoginBox1.Size = new Size(219, 34);
            LoginBox1.TabIndex = 0;
            LoginBox1.Tag = "";
            // 
            // PasswordBox1
            // 
            PasswordBox1.AccessibleDescription = "";
            PasswordBox1.AccessibleName = "password";
            PasswordBox1.Anchor = AnchorStyles.None;
            PasswordBox1.Location = new Point(218, 367);
            PasswordBox1.Margin = new Padding(4);
            PasswordBox1.Name = "PasswordBox1";
            PasswordBox1.Size = new Size(219, 34);
            PasswordBox1.TabIndex = 1;
            PasswordBox1.UseSystemPasswordChar = true;
            // 
            // LoginLabel
            // 
            LoginLabel.AccessibleDescription = "login label";
            LoginLabel.Anchor = AnchorStyles.None;
            LoginLabel.AutoSize = true;
            LoginLabel.Location = new Point(218, 279);
            LoginLabel.Margin = new Padding(4, 0, 4, 0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(65, 28);
            LoginLabel.TabIndex = 1;
            LoginLabel.Text = "Login:";
            // 
            // signInBtn
            // 
            signInBtn.Anchor = AnchorStyles.None;
            signInBtn.BackColor = SystemColors.GradientActiveCaption;
            signInBtn.Location = new Point(218, 425);
            signInBtn.Margin = new Padding(4);
            signInBtn.Name = "signInBtn";
            signInBtn.Size = new Size(219, 51);
            signInBtn.TabIndex = 2;
            signInBtn.Text = "s'authentifier";
            signInBtn.UseVisualStyleBackColor = false;
            signInBtn.Click += LoginClick;
            // 
            // espegicLogo
            // 
            espegicLogo.Anchor = AnchorStyles.None;
            espegicLogo.Image = (Image)resources.GetObject("espegicLogo.Image");
            espegicLogo.Location = new Point(218, 129);
            espegicLogo.Margin = new Padding(4);
            espegicLogo.Name = "espegicLogo";
            espegicLogo.Size = new Size(219, 137);
            espegicLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            espegicLogo.TabIndex = 3;
            espegicLogo.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(663, 30);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(116, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "&About";
            // 
            // label1
            // 
            label1.AccessibleDescription = "login label";
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(218, 342);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(133, 28);
            label1.TabIndex = 5;
            label1.Text = "Mot de passe:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(663, 573);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(espegicLogo);
            Controls.Add(signInBtn);
            Controls.Add(menuStrip1);
            Controls.Add(LoginLabel);
            Controls.Add(LoginBox1);
            Controls.Add(PasswordBox1);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MinimumSize = new Size(685, 624);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Authentification";
            ((System.ComponentModel.ISupportInitialize)espegicLogo).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginBox1;
        private TextBox PasswordBox1;
        private Label LoginLabel;
        private Button signInBtn;
        private PictureBox espegicLogo;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private HelpProvider helpProvider1;
        private Label label1;
        private Panel panel1;
    }
}
