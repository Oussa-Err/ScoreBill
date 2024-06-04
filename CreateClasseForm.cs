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
    public partial class CreateClasseForm : Form
    {
        public CreateClasseForm()
        {
            InitializeComponent();
        }

        private void CreateClasse_Load(object sender, EventArgs e)
        {

        }

        private void CreateClasseBtn_Click(object sender, EventArgs e)
        {
            GererEleveForm elevesForm = new();
            elevesForm.Show();
            this.Close();
        }
        
        private void AnnulerBtn_Click(object sender, EventArgs e)
        {
            GererClasseForm getClassesForm = new ();
            getClassesForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
