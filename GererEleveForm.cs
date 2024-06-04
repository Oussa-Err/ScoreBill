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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void parcourirClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GererClasseForm getClassesForm = new ();
            getClassesForm.Show();
            this.Close();
        }
    }
}
