using scoreBill.Utils;
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
    public partial class GererEleveForm : Form
    {
        public GererEleveForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AjouterEleve_Click(object sender, EventArgs e)
        {
            CreateEleveForm createEleveForm = new();
            FormPositionUtil.OpenNewForm(this, createEleveForm);

        }

        private void parcourirClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GererClasseForm getClassesForm = new();
            FormPositionUtil.OpenNewForm(this, getClassesForm);
        }
    }
}
