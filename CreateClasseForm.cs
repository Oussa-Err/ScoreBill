using scoreBill.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
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
            roundShapeBtn();
        }

        private void roundShapeBtn()
        {
            GraphicsPath path = new ();
            path.AddEllipse(0, 0, plusBtn.Width - 20, plusBtn.Height - 15);
            plusBtn.Region = new Region(path);
        }

        private void CreateClasse_Load(object sender, EventArgs e)
        {

        }

        private void CreateClasseBtn_Click(object sender, EventArgs e)
        {
            GererEleveForm elevesForm = new();
            FormPositionUtil.OpenNewForm(this, elevesForm);
        }

        private void AnnulerBtn_Click(object sender, EventArgs e)
        {
            GererClasseForm getClassesForm = new();
            FormPositionUtil.OpenNewForm(this, getClassesForm);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
