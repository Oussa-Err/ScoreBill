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
    public partial class GererClasseForm : Form
    {
        public GererClasseForm()
        {
            InitializeComponent();
        }

        private void AjouterClasseClick(object sender, EventArgs e)
        {
            CreateClasseForm createClasseForm = new();
            createClasseForm.Show();
            this.Visible = false;
        }

        private void SupprimerClasseClick(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
