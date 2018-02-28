using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Projet_CoAndCo
{
    public partial class frmBook : Projet_CoAndCo.frmMediaView
    {
        public frmBook()
        {
            InitializeComponent();
            label1.Text = "un nouveau texte";
            //Title("mon titre");
        }
    }
}
