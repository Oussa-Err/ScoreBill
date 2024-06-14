namespace scoreBill
{
    partial class ModifierEleveForm
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
            InformationGeneraleGroupBox = new GroupBox();
            dateInscriptionPicker = new DateTimePicker();
            NomBox = new TextBox();
            PrenomBox = new TextBox();
            AgeBox = new TextBox();
            DateInscriptionLabel = new Label();
            TelephoneBox = new TextBox();
            Classes = new ListBox();
            ExamensGroupBox = new GroupBox();
            NoteBox3 = new TextBox();
            MatiereLabel = new Label();
            MoyenneGeneraleLabel = new Label();
            SommesNoteLabel = new Label();
            NoteBox1 = new TextBox();
            NoteBox2 = new TextBox();
            PaimentGroupBox = new GroupBox();
            DueLabel = new Label();
            FraisCheckBox1 = new CheckBox();
            AjusterMensualiteBox = new TextBox();
            FraisInitialCheckBox = new CheckBox();
            AjusterMensualiteLabel = new Label();
            label3 = new Label();
            ModifierBtn = new Button();
            AnnulerBtn = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            parcourirClassesToolStripMenuItem = new ToolStripMenuItem();
            parcourirElevesToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            EnregistrerBtn = new Button();
            InformationGeneraleGroupBox.SuspendLayout();
            ExamensGroupBox.SuspendLayout();
            PaimentGroupBox.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // InformationGeneraleGroupBox
            // 
            InformationGeneraleGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            InformationGeneraleGroupBox.Controls.Add(dateInscriptionPicker);
            InformationGeneraleGroupBox.Controls.Add(NomBox);
            InformationGeneraleGroupBox.Controls.Add(PrenomBox);
            InformationGeneraleGroupBox.Controls.Add(AgeBox);
            InformationGeneraleGroupBox.Controls.Add(DateInscriptionLabel);
            InformationGeneraleGroupBox.Controls.Add(TelephoneBox);
            InformationGeneraleGroupBox.Controls.Add(Classes);
            InformationGeneraleGroupBox.Enabled = false;
            InformationGeneraleGroupBox.Font = new Font("Segoe UI", 15F);
            InformationGeneraleGroupBox.Location = new Point(93, 51);
            InformationGeneraleGroupBox.Name = "InformationGeneraleGroupBox";
            InformationGeneraleGroupBox.Size = new Size(830, 212);
            InformationGeneraleGroupBox.TabIndex = 1;
            InformationGeneraleGroupBox.TabStop = false;
            InformationGeneraleGroupBox.Text = "Information Générale :";
            // 
            // dateInscriptionPicker
            // 
            dateInscriptionPicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateInscriptionPicker.Font = new Font("Segoe UI", 11F);
            dateInscriptionPicker.Location = new Point(501, 158);
            dateInscriptionPicker.Name = "dateInscriptionPicker";
            dateInscriptionPicker.Size = new Size(323, 32);
            dateInscriptionPicker.TabIndex = 5;
            // 
            // NomBox
            // 
            NomBox.Font = new Font("Segoe UI", 12F);
            NomBox.Location = new Point(19, 70);
            NomBox.Name = "NomBox";
            NomBox.PlaceholderText = "Nom";
            NomBox.Size = new Size(151, 34);
            NomBox.TabIndex = 0;
            // 
            // PrenomBox
            // 
            PrenomBox.Font = new Font("Segoe UI", 12F);
            PrenomBox.Location = new Point(187, 70);
            PrenomBox.Name = "PrenomBox";
            PrenomBox.PlaceholderText = "Prenom";
            PrenomBox.Size = new Size(151, 34);
            PrenomBox.TabIndex = 1;
            // 
            // AgeBox
            // 
            AgeBox.Font = new Font("Segoe UI", 12F);
            AgeBox.Location = new Point(354, 70);
            AgeBox.Name = "AgeBox";
            AgeBox.PlaceholderText = "Age";
            AgeBox.Size = new Size(97, 34);
            AgeBox.TabIndex = 2;
            // 
            // DateInscriptionLabel
            // 
            DateInscriptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DateInscriptionLabel.AutoSize = true;
            DateInscriptionLabel.Font = new Font("Segoe UI", 12F);
            DateInscriptionLabel.Location = new Point(314, 158);
            DateInscriptionLabel.Name = "DateInscriptionLabel";
            DateInscriptionLabel.Size = new Size(171, 28);
            DateInscriptionLabel.TabIndex = 10;
            DateInscriptionLabel.Text = "Date d'inscription:";
            // 
            // TelephoneBox
            // 
            TelephoneBox.Font = new Font("Segoe UI", 12F);
            TelephoneBox.Location = new Point(625, 70);
            TelephoneBox.Name = "TelephoneBox";
            TelephoneBox.PlaceholderText = "Telephone";
            TelephoneBox.Size = new Size(189, 34);
            TelephoneBox.TabIndex = 4;
            // 
            // Classes
            // 
            Classes.Font = new Font("Segoe UI", 12F);
            Classes.FormattingEnabled = true;
            Classes.ItemHeight = 28;
            Classes.Location = new Point(469, 70);
            Classes.Name = "Classes";
            Classes.Size = new Size(140, 32);
            Classes.TabIndex = 3;
            // 
            // ExamensGroupBox
            // 
            ExamensGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ExamensGroupBox.Controls.Add(NoteBox3);
            ExamensGroupBox.Controls.Add(MatiereLabel);
            ExamensGroupBox.Controls.Add(MoyenneGeneraleLabel);
            ExamensGroupBox.Controls.Add(SommesNoteLabel);
            ExamensGroupBox.Controls.Add(NoteBox1);
            ExamensGroupBox.Controls.Add(NoteBox2);
            ExamensGroupBox.Enabled = false;
            ExamensGroupBox.Font = new Font("Segoe UI", 15F);
            ExamensGroupBox.Location = new Point(93, 269);
            ExamensGroupBox.Name = "ExamensGroupBox";
            ExamensGroupBox.Size = new Size(830, 195);
            ExamensGroupBox.TabIndex = 2;
            ExamensGroupBox.TabStop = false;
            ExamensGroupBox.Text = "Notes des Examens :";
            // 
            // NoteBox3
            // 
            NoteBox3.Font = new Font("Segoe UI", 12F);
            NoteBox3.Location = new Point(455, 57);
            NoteBox3.Name = "NoteBox3";
            NoteBox3.PlaceholderText = "Note 3";
            NoteBox3.Size = new Size(129, 34);
            NoteBox3.TabIndex = 8;
            // 
            // MatiereLabel
            // 
            MatiereLabel.AutoSize = true;
            MatiereLabel.Font = new Font("Segoe UI", 12F);
            MatiereLabel.Location = new Point(27, 57);
            MatiereLabel.Name = "MatiereLabel";
            MatiereLabel.Size = new Size(95, 28);
            MatiereLabel.TabIndex = 12;
            MatiereLabel.Text = "Matière 1";
            // 
            // MoyenneGeneraleLabel
            // 
            MoyenneGeneraleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MoyenneGeneraleLabel.AutoSize = true;
            MoyenneGeneraleLabel.Font = new Font("Segoe UI", 12F);
            MoyenneGeneraleLabel.Location = new Point(532, 164);
            MoyenneGeneraleLabel.Name = "MoyenneGeneraleLabel";
            MoyenneGeneraleLabel.Size = new Size(178, 28);
            MoyenneGeneraleLabel.TabIndex = 16;
            MoyenneGeneraleLabel.Text = "Moyenne générale:";
            // 
            // SommesNoteLabel
            // 
            SommesNoteLabel.AutoSize = true;
            SommesNoteLabel.Font = new Font("Segoe UI", 12F);
            SommesNoteLabel.Location = new Point(625, 57);
            SommesNoteLabel.Name = "SommesNoteLabel";
            SommesNoteLabel.Size = new Size(88, 28);
            SommesNoteLabel.TabIndex = 17;
            SommesNoteLabel.Text = "sommes:";
            // 
            // NoteBox1
            // 
            NoteBox1.Font = new Font("Segoe UI", 12F);
            NoteBox1.Location = new Point(155, 57);
            NoteBox1.Name = "NoteBox1";
            NoteBox1.PlaceholderText = "Note 1";
            NoteBox1.Size = new Size(129, 34);
            NoteBox1.TabIndex = 6;
            // 
            // NoteBox2
            // 
            NoteBox2.Font = new Font("Segoe UI", 12F);
            NoteBox2.Location = new Point(305, 57);
            NoteBox2.Name = "NoteBox2";
            NoteBox2.PlaceholderText = "Note 2";
            NoteBox2.Size = new Size(129, 34);
            NoteBox2.TabIndex = 7;
            // 
            // PaimentGroupBox
            // 
            PaimentGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PaimentGroupBox.Controls.Add(DueLabel);
            PaimentGroupBox.Controls.Add(FraisCheckBox1);
            PaimentGroupBox.Controls.Add(AjusterMensualiteBox);
            PaimentGroupBox.Controls.Add(FraisInitialCheckBox);
            PaimentGroupBox.Controls.Add(AjusterMensualiteLabel);
            PaimentGroupBox.Enabled = false;
            PaimentGroupBox.Font = new Font("Segoe UI", 15F);
            PaimentGroupBox.Location = new Point(93, 482);
            PaimentGroupBox.Name = "PaimentGroupBox";
            PaimentGroupBox.Size = new Size(830, 191);
            PaimentGroupBox.TabIndex = 3;
            PaimentGroupBox.TabStop = false;
            PaimentGroupBox.Text = "Frais Scolaire :";
            // 
            // DueLabel
            // 
            DueLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DueLabel.AutoSize = true;
            DueLabel.Font = new Font("Segoe UI", 12F);
            DueLabel.Location = new Point(576, 150);
            DueLabel.Name = "DueLabel";
            DueLabel.Size = new Size(134, 28);
            DueLabel.TabIndex = 23;
            DueLabel.Text = "Reste à Payer :";
            // 
            // FraisCheckBox1
            // 
            FraisCheckBox1.AutoSize = true;
            FraisCheckBox1.Font = new Font("Segoe UI", 12F);
            FraisCheckBox1.Location = new Point(25, 100);
            FraisCheckBox1.Name = "FraisCheckBox1";
            FraisCheckBox1.Size = new Size(93, 32);
            FraisCheckBox1.TabIndex = 11;
            FraisCheckBox1.Text = "Mois 1";
            FraisCheckBox1.UseVisualStyleBackColor = true;
            // 
            // AjusterMensualiteBox
            // 
            AjusterMensualiteBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AjusterMensualiteBox.Font = new Font("Segoe UI", 12F);
            AjusterMensualiteBox.Location = new Point(734, 22);
            AjusterMensualiteBox.Name = "AjusterMensualiteBox";
            AjusterMensualiteBox.PlaceholderText = "900";
            AjusterMensualiteBox.Size = new Size(90, 34);
            AjusterMensualiteBox.TabIndex = 9;
            // 
            // FraisInitialCheckBox
            // 
            FraisInitialCheckBox.AutoSize = true;
            FraisInitialCheckBox.Font = new Font("Segoe UI", 12F);
            FraisInitialCheckBox.Location = new Point(25, 62);
            FraisInitialCheckBox.Name = "FraisInitialCheckBox";
            FraisInitialCheckBox.Size = new Size(127, 32);
            FraisInitialCheckBox.TabIndex = 10;
            FraisInitialCheckBox.Text = "Frais Initial";
            FraisInitialCheckBox.UseVisualStyleBackColor = true;
            // 
            // AjusterMensualiteLabel
            // 
            AjusterMensualiteLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AjusterMensualiteLabel.AutoSize = true;
            AjusterMensualiteLabel.Font = new Font("Segoe UI", 12F);
            AjusterMensualiteLabel.Location = new Point(533, 22);
            AjusterMensualiteLabel.Name = "AjusterMensualiteLabel";
            AjusterMensualiteLabel.Size = new Size(201, 28);
            AjusterMensualiteLabel.TabIndex = 21;
            AjusterMensualiteLabel.Text = "Ajuster la mensualité :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(1, 201);
            label3.Name = "label3";
            label3.Size = new Size(0, 35);
            label3.TabIndex = 29;
            // 
            // ModifierBtn
            // 
            ModifierBtn.Anchor = AnchorStyles.Bottom;
            ModifierBtn.Location = new Point(757, 679);
            ModifierBtn.Name = "ModifierBtn";
            ModifierBtn.Size = new Size(166, 61);
            ModifierBtn.TabIndex = 5;
            ModifierBtn.Text = "Modifier";
            ModifierBtn.UseVisualStyleBackColor = true;
            ModifierBtn.Click += ModifierBtn_Click;
            // 
            // AnnulerBtn
            // 
            AnnulerBtn.Anchor = AnchorStyles.Bottom;
            AnnulerBtn.BackColor = Color.IndianRed;
            AnnulerBtn.ForeColor = Color.White;
            AnnulerBtn.Location = new Point(93, 679);
            AnnulerBtn.Name = "AnnulerBtn";
            AnnulerBtn.Size = new Size(183, 61);
            AnnulerBtn.TabIndex = 4;
            AnnulerBtn.Text = "Annuler";
            AnnulerBtn.UseVisualStyleBackColor = false;
            AnnulerBtn.Visible = false;
            AnnulerBtn.Click += AnnulerBtn_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1022, 28);
            menuStrip1.TabIndex = 33;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem, parcourirClassesToolStripMenuItem, parcourirElevesToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(201, 26);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click_1;
            // 
            // parcourirClassesToolStripMenuItem
            // 
            parcourirClassesToolStripMenuItem.Name = "parcourirClassesToolStripMenuItem";
            parcourirClassesToolStripMenuItem.Size = new Size(201, 26);
            parcourirClassesToolStripMenuItem.Text = "&Parcourir Classes";
            parcourirClassesToolStripMenuItem.Click += parcourirClassesToolStripMenuItem_Click;
            // 
            // parcourirElevesToolStripMenuItem
            // 
            parcourirElevesToolStripMenuItem.Name = "parcourirElevesToolStripMenuItem";
            parcourirElevesToolStripMenuItem.Size = new Size(201, 26);
            parcourirElevesToolStripMenuItem.Text = "Parcourir &Eleves";
            parcourirElevesToolStripMenuItem.Click += parcourirElevesToolStripMenuItem_Click_1;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "&About";
            // 
            // EnregistrerBtn
            // 
            EnregistrerBtn.Anchor = AnchorStyles.Bottom;
            EnregistrerBtn.Location = new Point(757, 679);
            EnregistrerBtn.Name = "EnregistrerBtn";
            EnregistrerBtn.Size = new Size(166, 61);
            EnregistrerBtn.TabIndex = 34;
            EnregistrerBtn.Text = "Enregistrer";
            EnregistrerBtn.UseVisualStyleBackColor = true;
            EnregistrerBtn.Visible = false;
            EnregistrerBtn.Click += EnregistrerBtn_Click;
            // 
            // ModifierEleveForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 771);
            Controls.Add(menuStrip1);
            Controls.Add(InformationGeneraleGroupBox);
            Controls.Add(ExamensGroupBox);
            Controls.Add(PaimentGroupBox);
            Controls.Add(label3);
            Controls.Add(ModifierBtn);
            Controls.Add(AnnulerBtn);
            Controls.Add(EnregistrerBtn);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MinimumSize = new Size(1040, 818);
            Name = "ModifierEleveForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modifier Eleve";
            InformationGeneraleGroupBox.ResumeLayout(false);
            InformationGeneraleGroupBox.PerformLayout();
            ExamensGroupBox.ResumeLayout(false);
            ExamensGroupBox.PerformLayout();
            PaimentGroupBox.ResumeLayout(false);
            PaimentGroupBox.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox InformationGeneraleGroupBox;
        private DateTimePicker dateInscriptionPicker;
        private TextBox NomBox;
        private TextBox PrenomBox;
        private TextBox AgeBox;
        private Label DateInscriptionLabel;
        private TextBox TelephoneBox;
        private ListBox Classes;
        private GroupBox ExamensGroupBox;
        private TextBox NoteBox3;
        private Label MatiereLabel;
        private Label MoyenneGeneraleLabel;
        private Label SommesNoteLabel;
        private TextBox NoteBox1;
        private TextBox NoteBox2;
        private GroupBox PaimentGroupBox;
        private Label DueLabel;
        private CheckBox FraisCheckBox1;
        private TextBox AjusterMensualiteBox;
        private CheckBox FraisInitialCheckBox;
        private Label AjusterMensualiteLabel;
        private Label label3;
        private Button ModifierBtn;
        private Button AnnulerBtn;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem parcourirClassesToolStripMenuItem;
        private ToolStripMenuItem parcourirElevesToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button EnregistrerBtn;
    }
}