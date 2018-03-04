using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projet_CoAndCo
{
    public partial class frmMenu : Form
    {
        User user;

        public frmMenu()
        {
            InitializeComponent();
        }

        // event functions
        private void buttonConnection_Click(object sender, EventArgs e)
        {
            // Show form Login
            ShowFormLogin();

        }

        private void menuBar_lblIdUser_TextChanged(object sender, EventArgs e)
        {
            // Display menu depending on user
            int idUser = Convert.ToInt32(menuBar_lblIdUser.Text);
            CnxUser(idUser);
        }


        private void ShowFormLogin()
        {
            Form FrmLogin = new frmLogin(menuBar_lblIdUser);
            FrmLogin.ShowDialog(this);
        }
        //
        // MenuFichier Event
        // -----------------
        private void menuFichier_DropDownOpened(object sender, EventArgs e)
        {
            this.menuBar_menuFichier.ForeColor = Color.Black;
        }

        private void menuFichier_DropDownClosed(object sender, EventArgs e)
        {
            this.menuBar_menuFichier.ForeColor = Color.White;
        }

        private void menuFichier_MouseHover(object sender, EventArgs e)
        {
            this.menuBar_menuFichier.ForeColor = Color.Black;
            this.menuBar_menuFichier.BackColor = Color.Turquoise;
        }
        private void menuAffichage_DropDownOpened(object sender, EventArgs e)
        {
            this.menuBar_menuAffichage.ForeColor = Color.Black;
        }

        private void menuAffichage_DropDownClosed(object sender, EventArgs e)
        {
            this.menuBar_menuAffichage.ForeColor = Color.White;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

            this.userTableAdapter.Fill(this.coAndCoDBDataSet.User);
            this.type_UserTableAdapter.Fill(this.coAndCoDBDataSet.Type_User);
            user = CnxUser(0);
            ShowMenus(user);
        }
     
    }
}
