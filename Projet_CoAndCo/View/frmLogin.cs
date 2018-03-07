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
        private User loginUser;

        public frmLogin(User user)
        {
            InitializeComponent();
            loginUser = user;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
             this.userTableAdapter.Fill(this.coAndCoDBDataSetLogin.User);
        }

        private void txtLogin_Validating(object sender, CancelEventArgs e)
        {
            if (txtLogin.Text == "") e.Cancel = true;

            newUser(!loginValidation(loginUser));
        }

        private void btnValid_Login_Click(object sender, EventArgs e)
        {
            if (ValidateConnexion(loginUser))
            {
                this.Close();
            }
        }
    }
}
