namespace scoreBill
{
    partial class GererEleveForm
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
            textBox1 = new TextBox();
            ExportEleve = new Button();
            SupprinerEleve = new Button();
            AjouterBtn = new Button();
            dataGridView1 = new DataGridView();
            fullName = new DataGridViewTextBoxColumn();
            moyenne = new DataGridViewTextBoxColumn();
            moisNonPaye = new DataGridViewTextBoxColumn();
            modifierEleve = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            parcourirClassesToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(380, 76);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Recherché élève par nom";
            textBox1.Size = new Size(313, 34);
            textBox1.TabIndex = 11;
            // 
            // ExportEleve
            // 
            ExportEleve.Location = new Point(51, 500);
            ExportEleve.Name = "ExportEleve";
            ExportEleve.Size = new Size(194, 44);
            ExportEleve.TabIndex = 8;
            ExportEleve.Text = "Exporter élèves";
            ExportEleve.UseVisualStyleBackColor = true;
            // 
            // SupprinerEleve
            // 
            SupprinerEleve.BackColor = Color.IndianRed;
            SupprinerEleve.ForeColor = Color.White;
            SupprinerEleve.Location = new Point(276, 500);
            SupprinerEleve.Name = "SupprinerEleve";
            SupprinerEleve.Size = new Size(194, 44);
            SupprinerEleve.TabIndex = 9;
            SupprinerEleve.Text = "Supprimer élèves";
            SupprinerEleve.UseVisualStyleBackColor = false;
            // 
            // AjouterBtn
            // 
            AjouterBtn.BackColor = SystemColors.GradientActiveCaption;
            AjouterBtn.Location = new Point(499, 500);
            AjouterBtn.Name = "AjouterBtn";
            AjouterBtn.Size = new Size(194, 44);
            AjouterBtn.TabIndex = 10;
            AjouterBtn.Text = "Ajouter un élève";
            AjouterBtn.UseVisualStyleBackColor = false;
            AjouterBtn.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fullName, moyenne, moisNonPaye, modifierEleve });
            dataGridView1.Location = new Point(51, 116);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(642, 364);
            dataGridView1.TabIndex = 7;
            // 
            // fullName
            // 
            fullName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            fullName.HeaderText = "nom et prenom";
            fullName.MinimumWidth = 6;
            fullName.Name = "fullName";
            fullName.Width = 177;
            // 
            // moyenne
            // 
            moyenne.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            moyenne.HeaderText = "Moyenne";
            moyenne.MinimumWidth = 6;
            moyenne.Name = "moyenne";
            // 
            // moisNonPaye
            // 
            moisNonPaye.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            moisNonPaye.HeaderText = "Mois non Payé";
            moisNonPaye.MinimumWidth = 6;
            moisNonPaye.Name = "moisNonPaye";
            // 
            // modifierEleve
            // 
            modifierEleve.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            modifierEleve.HeaderText = "";
            modifierEleve.MinimumWidth = 6;
            modifierEleve.Name = "modifierEleve";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(772, 28);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem, parcourirClassesToolStripMenuItem });
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
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "&About";
            // 
            // GererEleveForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(772, 639);
            Controls.Add(menuStrip1);
            Controls.Add(textBox1);
            Controls.Add(ExportEleve);
            Controls.Add(SupprinerEleve);
            Controls.Add(AjouterBtn);
            Controls.Add(dataGridView1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "GererEleveForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ElevesForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button ExportEleve;
        private Button SupprinerEleve;
        private Button AjouterBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn fullName;
        private DataGridViewTextBoxColumn moyenne;
        private DataGridViewTextBoxColumn moisNonPaye;
        private DataGridViewTextBoxColumn modifierEleve;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem parcourirClassesToolStripMenuItem;
    }
}