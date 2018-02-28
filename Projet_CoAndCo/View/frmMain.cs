using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projet_CoAndCo
{
    public partial class frmMain : Projet_CoAndCo.frmMenu
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Click(object sender, EventArgs e)
        {
            Form FrmSearch = new frmSearch();
            FrmSearch.Show();
            this.Hide();
        }
    }
}
