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
using static System.Windows.Forms.DataFormats;

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
            CreateClasseForm createClasseForm = new ();
            FormPositionUtil.OpenNewForm(this, createClasseForm);
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
