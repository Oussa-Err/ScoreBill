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


        private void ModifierBtn_Click_1(object sender, EventArgs e)
        {
            ModifierEleveForm modifierEleveForm = new();
            modifierEleveForm.Show();
            this.Close();
        }
        private void parcourirClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GererClasseForm gererClasseForm = new();
            gererClasseForm.Show();
            this.Close();
        }
        private void parcourirElevesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GererEleveForm gererEleveForm = new();
            gererEleveForm.Show();

        }

    }
}