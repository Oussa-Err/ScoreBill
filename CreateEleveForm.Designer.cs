namespace scoreBill
{
    partial class CreateEleveForm
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
            AnnulerBtn = new Button();
            NomBox = new TextBox();
            PrenomBox = new TextBox();
            AgeBox = new TextBox();
            TelephoneBox = new TextBox();
            dateInscriptionPicker = new DateTimePicker();
            Classes = new ListBox();
            DateInscriptionLabel = new Label();
            label3 = new Label();
            MatiereLabel = new Label();
            NoteBox1 = new TextBox();
            NoteBox2 = new TextBox();
            NoteBox3 = new TextBox();
            MoyenneGeneraleLabel = new Label();
            SommesNoteLabel = new Label();
            AjusterMensualiteLabel = new Label();
            AjusterMensualiteBox = new TextBox();
            FraisCheckBox1 = new CheckBox();
            FraisInitialCheckBox = new CheckBox();
            DueLabel = new Label();
            PaimentGroupBox = new GroupBox();
            ExamensGroupBox = new GroupBox();
            InformationGeneraleGroupBox = new GroupBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            parcourirClassesToolStripMenuItem = new ToolStripMenuItem();
            parcourirElevesToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            EnregistrerBtn = new Button();
            PaimentGroupBox.SuspendLayout();
            ExamensGroupBox.SuspendLayout();
            InformationGeneraleGroupBox.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // AnnulerBtn
            // 
            AnnulerBtn.BackColor = Color.IndianRed;
            AnnulerBtn.ForeColor = Color.White;
            AnnulerBtn.Location = new Point(599, 68);
            AnnulerBtn.Name = "AnnulerBtn";
            AnnulerBtn.Size = new Size(126, 45);
            AnnulerBtn.TabIndex = 0;
            AnnulerBtn.Text = "Annuler";
            AnnulerBtn.UseVisualStyleBackColor = false;
            AnnulerBtn.Click += AnnulerBtn_Click;
            // 
            // NomBox
            // 
            NomBox.Font = new Font("Segoe UI", 12F);
            NomBox.Location = new Point(19, 70);
            NomBox.Name = "NomBox";
            NomBox.PlaceholderText = "Nom";
            NomBox.Size = new Size(129, 34);
            NomBox.TabIndex = 0;
            // 
            // PrenomBox
            // 
            PrenomBox.Font = new Font("Segoe UI", 12F);
            PrenomBox.Location = new Point(171, 70);
            PrenomBox.Name = "PrenomBox";
            PrenomBox.PlaceholderText = "Prenom";
            PrenomBox.Size = new Size(137, 34);
            PrenomBox.TabIndex = 1;
            // 
            // AgeBox
            // 
            AgeBox.Font = new Font("Segoe UI", 12F);
            AgeBox.Location = new Point(342, 70);
            AgeBox.Name = "AgeBox";
            AgeBox.PlaceholderText = "Age";
            AgeBox.Size = new Size(97, 34);
            AgeBox.TabIndex = 2;
            // 
            // TelephoneBox
            // 
            TelephoneBox.Font = new Font("Segoe UI", 12F);
            TelephoneBox.Location = new Point(600, 70);
            TelephoneBox.Name = "TelephoneBox";
            TelephoneBox.PlaceholderText = "Telephone";
            TelephoneBox.Size = new Size(164, 34);
            TelephoneBox.TabIndex = 4;
            // 
            // dateInscriptionPicker
            // 
            dateInscriptionPicker.Font = new Font("Segoe UI", 11F);
            dateInscriptionPicker.Location = new Point(441, 158);
            dateInscriptionPicker.Name = "dateInscriptionPicker";
            dateInscriptionPicker.Size = new Size(323, 32);
            dateInscriptionPicker.TabIndex = 5;
            // 
            // Classes
            // 
            Classes.Font = new Font("Segoe UI", 12F);
            Classes.FormattingEnabled = true;
            Classes.ItemHeight = 28;
            Classes.Location = new Point(460, 70);
            Classes.Name = "Classes";
            Classes.Size = new Size(125, 32);
            Classes.TabIndex = 3;
            // 
            // DateInscriptionLabel
            // 
            DateInscriptionLabel.AutoSize = true;
            DateInscriptionLabel.Font = new Font("Segoe UI", 12F);
            DateInscriptionLabel.Location = new Point(254, 158);
            DateInscriptionLabel.Name = "DateInscriptionLabel";
            DateInscriptionLabel.Size = new Size(171, 28);
            DateInscriptionLabel.TabIndex = 10;
            DateInscriptionLabel.Text = "Date d'inscription:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(90, 286);
            label3.Name = "label3";
            label3.Size = new Size(0, 35);
            label3.TabIndex = 11;
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
            // NoteBox3
            // 
            NoteBox3.Font = new Font("Segoe UI", 12F);
            NoteBox3.Location = new Point(455, 57);
            NoteBox3.Name = "NoteBox3";
            NoteBox3.PlaceholderText = "Note 3";
            NoteBox3.Size = new Size(129, 34);
            NoteBox3.TabIndex = 8;
            // 
            // MoyenneGeneraleLabel
            // 
            MoyenneGeneraleLabel.AutoSize = true;
            MoyenneGeneraleLabel.Font = new Font("Segoe UI", 12F);
            MoyenneGeneraleLabel.Location = new Point(472, 164);
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
            // AjusterMensualiteLabel
            // 
            AjusterMensualiteLabel.AutoSize = true;
            AjusterMensualiteLabel.Font = new Font("Segoe UI", 12F);
            AjusterMensualiteLabel.Location = new Point(483, 16);
            AjusterMensualiteLabel.Name = "AjusterMensualiteLabel";
            AjusterMensualiteLabel.Size = new Size(201, 28);
            AjusterMensualiteLabel.TabIndex = 21;
            AjusterMensualiteLabel.Text = "Ajuster la mensualité :";
            // 
            // AjusterMensualiteBox
            // 
            AjusterMensualiteBox.Font = new Font("Segoe UI", 12F);
            AjusterMensualiteBox.Location = new Point(680, 16);
            AjusterMensualiteBox.Name = "AjusterMensualiteBox";
            AjusterMensualiteBox.PlaceholderText = "900";
            AjusterMensualiteBox.Size = new Size(90, 34);
            AjusterMensualiteBox.TabIndex = 9;
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
            // DueLabel
            // 
            DueLabel.AutoSize = true;
            DueLabel.Font = new Font("Segoe UI", 12F);
            DueLabel.Location = new Point(516, 150);
            DueLabel.Name = "DueLabel";
            DueLabel.Size = new Size(134, 28);
            DueLabel.TabIndex = 23;
            DueLabel.Text = "Reste à Payer :";
            // 
            // PaimentGroupBox
            // 
            PaimentGroupBox.Controls.Add(DueLabel);
            PaimentGroupBox.Controls.Add(FraisCheckBox1);
            PaimentGroupBox.Controls.Add(AjusterMensualiteBox);
            PaimentGroupBox.Controls.Add(FraisInitialCheckBox);
            PaimentGroupBox.Controls.Add(AjusterMensualiteLabel);
            PaimentGroupBox.Font = new Font("Segoe UI", 15F);
            PaimentGroupBox.Location = new Point(90, 550);
            PaimentGroupBox.Name = "PaimentGroupBox";
            PaimentGroupBox.Size = new Size(770, 191);
            PaimentGroupBox.TabIndex = 24;
            PaimentGroupBox.TabStop = false;
            PaimentGroupBox.Text = "Frais Scolaire :";
            // 
            // ExamensGroupBox
            // 
            ExamensGroupBox.Controls.Add(NoteBox3);
            ExamensGroupBox.Controls.Add(MatiereLabel);
            ExamensGroupBox.Controls.Add(MoyenneGeneraleLabel);
            ExamensGroupBox.Controls.Add(SommesNoteLabel);
            ExamensGroupBox.Controls.Add(NoteBox1);
            ExamensGroupBox.Controls.Add(NoteBox2);
            ExamensGroupBox.Font = new Font("Segoe UI", 15F);
            ExamensGroupBox.Location = new Point(90, 349);
            ExamensGroupBox.Name = "ExamensGroupBox";
            ExamensGroupBox.Size = new Size(770, 195);
            ExamensGroupBox.TabIndex = 25;
            ExamensGroupBox.TabStop = false;
            ExamensGroupBox.Text = "Notes des Examens :";
            // 
            // InformationGeneraleGroupBox
            // 
            InformationGeneraleGroupBox.Controls.Add(dateInscriptionPicker);
            InformationGeneraleGroupBox.Controls.Add(NomBox);
            InformationGeneraleGroupBox.Controls.Add(PrenomBox);
            InformationGeneraleGroupBox.Controls.Add(AgeBox);
            InformationGeneraleGroupBox.Controls.Add(DateInscriptionLabel);
            InformationGeneraleGroupBox.Controls.Add(TelephoneBox);
            InformationGeneraleGroupBox.Controls.Add(Classes);
            InformationGeneraleGroupBox.Font = new Font("Segoe UI", 15F);
            InformationGeneraleGroupBox.Location = new Point(90, 119);
            InformationGeneraleGroupBox.Name = "InformationGeneraleGroupBox";
            InformationGeneraleGroupBox.Size = new Size(770, 212);
            InformationGeneraleGroupBox.TabIndex = 26;
            InformationGeneraleGroupBox.TabStop = false;
            InformationGeneraleGroupBox.Text = "Information Générale :";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(959, 28);
            menuStrip1.TabIndex = 27;
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
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
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
            parcourirElevesToolStripMenuItem.Click += parcourirElevesToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "&About";
            // 
            // EnregistrerBtn
            // 
            EnregistrerBtn.Location = new Point(731, 68);
            EnregistrerBtn.Name = "EnregistrerBtn";
            EnregistrerBtn.Size = new Size(129, 45);
            EnregistrerBtn.TabIndex = 29;
            EnregistrerBtn.Text = "Enregistrer";
            EnregistrerBtn.UseVisualStyleBackColor = true;
            // 
            // CreateEleveForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 765);
            Controls.Add(EnregistrerBtn);
            Controls.Add(menuStrip1);
            Controls.Add(InformationGeneraleGroupBox);
            Controls.Add(ExamensGroupBox);
            Controls.Add(PaimentGroupBox);
            Controls.Add(label3);
            Controls.Add(AnnulerBtn);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "CreateEleveForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateEleveForm";
            PaimentGroupBox.ResumeLayout(false);
            PaimentGroupBox.PerformLayout();
            ExamensGroupBox.ResumeLayout(false);
            ExamensGroupBox.PerformLayout();
            InformationGeneraleGroupBox.ResumeLayout(false);
            InformationGeneraleGroupBox.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AnnulerBtn;
        private TextBox NomBox;
        private TextBox PrenomBox;
        private TextBox AgeBox;
        private TextBox TelephoneBox;
        private DateTimePicker dateInscriptionPicker;
        private ListBox Classes;
        private Label DateInscriptionLabel;
        private Label label3;
        private Label MatiereLabel;
        private TextBox NoteBox1;
        private TextBox NoteBox2;
        private TextBox NoteBox3;
        private Label MoyenneGeneraleLabel;
        private Label SommesNoteLabel;
        private Label AjusterMensualiteLabel;
        private TextBox AjusterMensualiteBox;
        private CheckBox FraisCheckBox1;
        private CheckBox FraisInitialCheckBox;
        private Label DueLabel;
        private GroupBox PaimentGroupBox;
        private GroupBox ExamensGroupBox;
        private GroupBox InformationGeneraleGroupBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem parcourirClassesToolStripMenuItem;
        private ToolStripMenuItem parcourirElevesToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button EnregistrerBtn;
    }
}