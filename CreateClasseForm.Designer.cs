namespace scoreBill
{
    partial class CreateClasseForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            CreateClasseBtn = new Button();
            AnnulerBtn = new Button();
            NomClasse = new TextBox();
            NomClasseLabel = new Label();
            NomMatiereLabel = new Label();
            NomsMatiere = new TextBox();
            NbrMatiereLabel = new Label();
            NbrMatiere = new TextBox();
            NbrMoisLabel = new Label();
            NbrMois = new TextBox();
            label1 = new Label();
            FraisInitial = new TextBox();
            label2 = new Label();
            FraisMensuel = new TextBox();
            button1 = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(772, 28);
            menuStrip1.TabIndex = 0;
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
            // CreateClasseBtn
            // 
            CreateClasseBtn.Anchor = AnchorStyles.Top;
            CreateClasseBtn.BackColor = SystemColors.GradientActiveCaption;
            CreateClasseBtn.Location = new Point(469, 513);
            CreateClasseBtn.Name = "CreateClasseBtn";
            CreateClasseBtn.Size = new Size(164, 49);
            CreateClasseBtn.TabIndex = 7;
            CreateClasseBtn.Text = "Enregister";
            CreateClasseBtn.UseVisualStyleBackColor = false;
            CreateClasseBtn.Click += CreateClasseBtn_Click;
            // 
            // AnnulerBtn
            // 
            AnnulerBtn.Anchor = AnchorStyles.Top;
            AnnulerBtn.BackColor = Color.IndianRed;
            AnnulerBtn.ForeColor = Color.White;
            AnnulerBtn.Location = new Point(92, 513);
            AnnulerBtn.Name = "AnnulerBtn";
            AnnulerBtn.Size = new Size(164, 49);
            AnnulerBtn.TabIndex = 6;
            AnnulerBtn.Text = "Annuler";
            AnnulerBtn.UseVisualStyleBackColor = false;
            AnnulerBtn.Click += AnnulerBtn_Click;
            // 
            // NomClasse
            // 
            NomClasse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NomClasse.Location = new Point(422, 102);
            NomClasse.Name = "NomClasse";
            NomClasse.Size = new Size(211, 34);
            NomClasse.TabIndex = 0;
            // 
            // NomClasseLabel
            // 
            NomClasseLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NomClasseLabel.AutoSize = true;
            NomClasseLabel.Location = new Point(92, 102);
            NomClasseLabel.Name = "NomClasseLabel";
            NomClasseLabel.Size = new Size(158, 28);
            NomClasseLabel.TabIndex = 3;
            NomClasseLabel.Text = "Nom de la classe";
            // 
            // NomMatiereLabel
            // 
            NomMatiereLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NomMatiereLabel.AutoSize = true;
            NomMatiereLabel.Location = new Point(92, 162);
            NomMatiereLabel.Name = "NomMatiereLabel";
            NomMatiereLabel.Size = new Size(155, 28);
            NomMatiereLabel.TabIndex = 5;
            NomMatiereLabel.Text = "Nom du matière";
            // 
            // NomsMatiere
            // 
            NomsMatiere.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NomsMatiere.Location = new Point(422, 162);
            NomsMatiere.Name = "NomsMatiere";
            NomsMatiere.Size = new Size(211, 34);
            NomsMatiere.TabIndex = 1;
            // 
            // NbrMatiereLabel
            // 
            NbrMatiereLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NbrMatiereLabel.AutoSize = true;
            NbrMatiereLabel.Location = new Point(92, 227);
            NbrMatiereLabel.Name = "NbrMatiereLabel";
            NbrMatiereLabel.Size = new Size(279, 28);
            NbrMatiereLabel.TabIndex = 7;
            NbrMatiereLabel.Text = "Nombre d'examen par matière";
            // 
            // NbrMatiere
            // 
            NbrMatiere.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NbrMatiere.Location = new Point(422, 227);
            NbrMatiere.Name = "NbrMatiere";
            NbrMatiere.Size = new Size(211, 34);
            NbrMatiere.TabIndex = 2;
            // 
            // NbrMoisLabel
            // 
            NbrMoisLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NbrMoisLabel.AutoSize = true;
            NbrMoisLabel.Location = new Point(92, 288);
            NbrMoisLabel.Name = "NbrMoisLabel";
            NbrMoisLabel.Size = new Size(234, 28);
            NbrMoisLabel.TabIndex = 9;
            NbrMoisLabel.Text = "Periode Formation / mois";
            // 
            // NbrMois
            // 
            NbrMois.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NbrMois.Location = new Point(422, 285);
            NbrMois.Name = "NbrMois";
            NbrMois.Size = new Size(211, 34);
            NbrMois.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(92, 351);
            label1.Name = "label1";
            label1.Size = new Size(151, 28);
            label1.TabIndex = 11;
            label1.Text = "Frais Initial / DH";
            // 
            // FraisInitial
            // 
            FraisInitial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FraisInitial.Location = new Point(422, 348);
            FraisInitial.Name = "FraisInitial";
            FraisInitial.Size = new Size(211, 34);
            FraisInitial.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(92, 414);
            label2.Name = "label2";
            label2.Size = new Size(176, 28);
            label2.TabIndex = 13;
            label2.Text = "Frais Mensuel / DH";
            // 
            // FraisMensuel
            // 
            FraisMensuel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FraisMensuel.Location = new Point(422, 411);
            FraisMensuel.Name = "FraisMensuel";
            FraisMensuel.Size = new Size(211, 34);
            FraisMensuel.TabIndex = 5;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 16F);
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(660, 162);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(52, 46);
            button1.TabIndex = 14;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            // 
            // CreateClasseForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 639);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(FraisMensuel);
            Controls.Add(label1);
            Controls.Add(FraisInitial);
            Controls.Add(NbrMoisLabel);
            Controls.Add(NbrMois);
            Controls.Add(NbrMatiereLabel);
            Controls.Add(NbrMatiere);
            Controls.Add(NomMatiereLabel);
            Controls.Add(NomsMatiere);
            Controls.Add(NomClasseLabel);
            Controls.Add(NomClasse);
            Controls.Add(AnnulerBtn);
            Controls.Add(CreateClasseBtn);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MinimumSize = new Size(790, 686);
            Name = "CreateClasseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Creer une Classe";
            Load += CreateClasse_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button CreateClasseBtn;
        private Button AnnulerBtn;
        private TextBox NomClasse;
        private Label NomClasseLabel;
        private Label NomMatiereLabel;
        private TextBox NomsMatiere;
        private Label NbrMatiereLabel;
        private TextBox NbrMatiere;
        private Label NbrMoisLabel;
        private TextBox NbrMois;
        private Label label1;
        private TextBox FraisInitial;
        private Label label2;
        private TextBox FraisMensuel;
        private Button button1;
    }
}