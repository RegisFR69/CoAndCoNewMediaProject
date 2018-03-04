using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace Projet_CoAndCo
{
    public partial class frmLogin : Form
    {
        private ToolStripMenuItem lblidUser = new ToolStripMenuItem();
        private int idUser;

        public frmLogin(ToolStripMenuItem user)
        {
            InitializeComponent();
            this.lblidUser = user;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
             this.userTableAdapter.Fill(this.coAndCoDBDataSetLogin.User);
        }

        private void txtId_Login_Validating(object sender, CancelEventArgs e)
        {
            if (txtId_Login.Text == "")
            {
                e.Cancel = true;
            }
            else
            {
                ArrayList loginList = UserLoginList();
                if (loginList.Contains(txtId_Login.Text))
                {
                    NewUser(false);
                    idUser = loginList.IndexOf(txtId_Login.Text);
                }
                else
                {
                    NewUser(true);
                    idUser = loginList.Count;
                }
            }
        }

        private void btnValid_Login_Click(object sender, EventArgs e)
        {
            if (ValidateConnexion())
            {
                this.Close();
            }
        }
    }
}
