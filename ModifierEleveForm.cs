using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scoreBill
{
    public partial class ModifierEleveForm : Form
    {
        public ModifierEleveForm()
        {
            InitializeComponent();
        }
        private void AnnulerBtn_Click(object sender, EventArgs e)
        {
            this.InformationGeneraleGroupBox.Enabled = false;
            this.ExamensGroupBox.Enabled = false;
            this.PaimentGroupBox.Enabled = false;
            this.ModifierBtn.Visible = true;
            this.EnregistrerBtn.Visible = false;
            this.AnnulerBtn.Visible = false;
        }

        private void ModifierBtn_Click(object sender, EventArgs e)
        {
            this.InformationGeneraleGroupBox.Enabled = true;
            this.ExamensGroupBox.Enabled = true;
            this.PaimentGroupBox.Enabled = true;
            this.ModifierBtn.Visible = false;
            this.EnregistrerBtn.Visible = true;
            this.AnnulerBtn.Visible = true;
        }

        private void EnregistrerBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void parcourirClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GererClasseForm gererClasseForm = new();
            gererClasseForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void parcourirElevesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GererEleveForm gererEleveForm = new();
            gererEleveForm.Show();
        }
    }
}