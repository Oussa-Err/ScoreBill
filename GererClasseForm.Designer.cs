namespace scoreBill
{
    partial class GererClasseForm
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
            ajouterClasseBtn = new Button();
            SupprimerClasseBtn = new Button();
            dataGridView1 = new DataGridView();
            nomDeLaClasse = new DataGridViewTextBoxColumn();
            nbrEleve = new DataGridViewTextBoxColumn();
            accessClasse = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ajouterClasseBtn
            // 
            ajouterClasseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ajouterClasseBtn.BackColor = SystemColors.GradientActiveCaption;
            ajouterClasseBtn.Location = new Point(546, 461);
            ajouterClasseBtn.Margin = new Padding(4);
            ajouterClasseBtn.Name = "ajouterClasseBtn";
            ajouterClasseBtn.Size = new Size(165, 53);
            ajouterClasseBtn.TabIndex = 0;
            ajouterClasseBtn.Text = "Ajouter Classe";
            ajouterClasseBtn.UseVisualStyleBackColor = false;
            ajouterClasseBtn.Click += AjouterClasseClick;
            // 
            // SupprimerClasseBtn
            // 
            SupprimerClasseBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SupprimerClasseBtn.BackColor = Color.IndianRed;
            SupprimerClasseBtn.ForeColor = Color.White;
            SupprimerClasseBtn.Location = new Point(54, 461);
            SupprimerClasseBtn.Margin = new Padding(4);
            SupprimerClasseBtn.Name = "SupprimerClasseBtn";
            SupprimerClasseBtn.Size = new Size(210, 53);
            SupprimerClasseBtn.TabIndex = 1;
            SupprimerClasseBtn.Text = "Supprimer Classe";
            SupprimerClasseBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nomDeLaClasse, nbrEleve, accessClasse });
            dataGridView1.Location = new Point(54, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(657, 320);
            dataGridView1.TabIndex = 1;
            // 
            // nomDeLaClasse
            // 
            nomDeLaClasse.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nomDeLaClasse.HeaderText = "Nom de la classe";
            nomDeLaClasse.MinimumWidth = 6;
            nomDeLaClasse.Name = "nomDeLaClasse";
            nomDeLaClasse.Resizable = DataGridViewTriState.True;
            // 
            // nbrEleve
            // 
            nbrEleve.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nbrEleve.HeaderText = "nombre d'élèves";
            nbrEleve.MinimumWidth = 6;
            nbrEleve.Name = "nbrEleve";
            nbrEleve.Resizable = DataGridViewTriState.False;
            // 
            // accessClasse
            // 
            accessClasse.HeaderText = "";
            accessClasse.MinimumWidth = 6;
            accessClasse.Name = "accessClasse";
            accessClasse.Width = 125;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(772, 28);
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
            // GererClasseForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 639);
            Controls.Add(dataGridView1);
            Controls.Add(SupprimerClasseBtn);
            Controls.Add(ajouterClasseBtn);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "GererClasseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Parcourir Classes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ajouterClasseBtn;
        private Button SupprimerClasseBtn;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private DataGridViewTextBoxColumn nomDeLaClasse;
        private DataGridViewTextBoxColumn nbrEleve;
        private DataGridViewTextBoxColumn accessClasse;
    }
}