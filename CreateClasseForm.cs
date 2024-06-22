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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            GraphicsPath path = new();
            path.AddEllipse(0, 0, plusBtn.Width - 20, plusBtn.Height - 15);
            plusBtn.Region = new Region(path);
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

        private int textBoxCount = 1;

        private void plusBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox newTextBox = new();

            textBoxCount++;
            if (textBoxCount >= 5) {
                MessageBox.Show("can't have more than 5");
                return;
            }
            string newTextBoxName = $"Module{textBoxCount}";
            newTextBox.Name = newTextBoxName;
            newTextBox.Size = new Size(211, 34);

            int previousTextBoxX = 0;


            foreach (Control control in this.Controls)
            {
                if (control is System.Windows.Forms.TextBox && control.Name != newTextBoxName)
                {
                    previousTextBoxX = control.Location.X;
                }
            }

            newTextBox.Location = new Point(previousTextBoxX + 230 , 162);

            this.Controls.Add(newTextBox);
        }
    }
}
