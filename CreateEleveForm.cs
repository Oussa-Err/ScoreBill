﻿using scoreBill.Utils;
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
    public partial class CreateEleveForm : Form
    {
        public CreateEleveForm()
        {
            InitializeComponent();
        }

        private void AnnulerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            GererEleveForm gererEleveForm = new();
            FormPositionUtil.OpenNewForm(this, gererEleveForm);
        }

        private void parcourirClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GererClasseForm gererClasseForm = new();
            FormPositionUtil.OpenNewForm(this, gererClasseForm);
        }
        private void parcourirElevesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GererEleveForm gererEleveForm = new();
            FormPositionUtil.OpenNewForm(this, gererEleveForm);
        }

        private void EnregistrerBtn_Click(object sender, EventArgs e)
        {
            ModifierEleveForm modifierEleveForm = new();
            FormPositionUtil.OpenNewForm(this, modifierEleveForm);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
