using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_CoAndCo
{
    public partial class frmMediaView : Form
    {
        public frmMediaView()
        {
            InitializeComponent();
        }

        public void Title(String newTitle)
        {
            lbl_MoviePanel_Titre.Text = newTitle;
        }
    }
}
