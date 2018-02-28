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
    public partial class frmLogin : Form
    {
        private ToolStripMenuItem TypeUser = new ToolStripMenuItem();

        public frmLogin(ToolStripMenuItem typeUser)
        {
            InitializeComponent();
            TypeUser = typeUser;
        }

        private void btnValid_Login_Click(object sender, EventArgs e)
        {
            if (ValidateConnexion())
            {
                this.Close();
            }
        }

        private Boolean ValidateConnexion()
        {
            if (txtPass2_Login.Visible)
            {
                // if (password 1 & 2 match)
                // update DB with new user
                // TypeUser.Text = "1";
                // return true;
                // else
                // delete txtbox 1 & 2
            }
            else
            {
                // typeUserId = password matches with login in DB
                // if typeUserId != 0
                // TypeUser.Text = typeUserId;
                // return true
                // else
                // delete txtbox 1
            }
            return false;
        }

        private void txtId_Login_Leave(object sender, EventArgs e)
        {
            if (txtId_Login.Text != "" && txtId_Login.Text != "regis" && txtId_Login.Text != "samuel") // login in DB
            {
                NewUser(false);
            }
            else
            {
                NewUser(true);
            }
        }

        private void NewUser(Boolean value)
        {
            lblTitre_Login.Visible = value;
            lblPass2_Login.Visible = value;
            txtPass2_Login.Visible = value;
        }
    }
}
