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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            User user = new User(0, 0);
            ShowMenus(user.GetIdUser());
        }

        // event functions
        private void buttonConnection_Click(object sender, EventArgs e)
        {
            // Show form Login
            ShowFormLogin();

            // Display menu depending on type user
            int typeUser = Convert.ToInt32(menuBar_lblIdTypeUser.Text);
            ShowMenus(typeUser);
        }
            
       

        private void ShowFormLogin()
        {
            Form FrmLogin = new frmLogin(menuBar_lblIdTypeUser);
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
            // TODO: cette ligne de code charge les données dans la table 'coAndCoDBDataSet.User'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.userTableAdapter.Fill(this.coAndCoDBDataSet.User);
            menuBar_txtMemberName.Text = coAndCoDBDataSet.User.Rows[1][2].ToString();
        }
    }
}
