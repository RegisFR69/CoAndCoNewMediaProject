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
        const string CONNECT = "Connexion";
        const string DISCONNECT = "Déconnexion";
        User user;

        public frmMenu()
        {
            InitializeComponent();
        }

        // event functions
        private void buttonConnection_Click(object sender, EventArgs e)
        {
            if (menuBar_btnConnection.Text == CONNECT)
            {
                // Show form Login
                ShowFormLogin();
            }
            else
            {
                menuBar_lblIdUser.Text = "0";
            }

            

        }

        private void menuBar_lblIdUser_TextChanged(object sender, EventArgs e)
        {
            // Display menu depending on user
            int idUser = Convert.ToInt32(menuBar_lblIdUser.Text);
            user = CnxUser(idUser);
            ShowMenus(user);
        }


        private void ShowFormLogin()
        {
            Form FrmLogin = new frmLogin(menuBar_lblIdUser);
            FrmLogin.ShowDialog(this);
        }

        //
        // MenuFichier Event
        // -----------------
        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.userTableAdapter.Fill(this.coAndCoDBDataSet.User);
            this.type_UserTableAdapter.Fill(this.coAndCoDBDataSet.Type_User);
            user = CnxUser(0);
            ShowMenus(user);
        }

        // menu ForeColor
        // Fichier
        private void menuBar_menuFichier_MouseEnter(object sender, EventArgs e)
        {
            this.menuBar_menuFichier.ForeColor = Color.Black;
        }
        private void menuBar_menuFichier_MouseLeave(object sender, EventArgs e)
        {
            if (!menuBar_menuFichier.Pressed) this.menuBar_menuFichier.ForeColor = Color.White;
        }
        private void menuBar_menuFichier_DropDownClosed(object sender, EventArgs e)
        {
            this.menuBar_menuFichier.ForeColor = Color.White;
        }

        // Affichage
        private void menuBar_menuAffichage_MouseEnter(object sender, EventArgs e)
        {
            this.menuBar_menuAffichage.ForeColor = Color.Black;
        }
        private void menuBar_menuAffichage_MouseLeave(object sender, EventArgs e)
        {
            if (!menuBar_menuAffichage.Pressed) this.menuBar_menuAffichage.ForeColor = Color.White;
        }
        private void menuBar_menuAffichage_DropDownClosed(object sender, EventArgs e)
        {
            this.menuBar_menuAffichage.ForeColor = Color.White;
        }

        // Media
        private void menuBar_menuMedia_MouseEnter(object sender, EventArgs e)
        {
            this.menuBar_menuMedia.ForeColor = Color.Black;
        }
        private void menuBar_menuMedia_MouseLeave(object sender, EventArgs e)
        {
            if (!menuBar_menuMedia.Pressed) this.menuBar_menuMedia.ForeColor = Color.White;
        }
        private void menuBar_menuMedia_DropDownClosed(object sender, EventArgs e)
        {
            this.menuBar_menuMedia.ForeColor = Color.White;
        }

        // Playlist
        private void menuBar_menuPlaylist_MouseEnter(object sender, EventArgs e)
        {
            this.menuBar_menuPlaylist.ForeColor = Color.Black;
        }
        private void menuBar_menuPlaylist_MouseLeave(object sender, EventArgs e)
        {
            if (!menuBar_menuPlaylist.Pressed) this.menuBar_menuPlaylist.ForeColor = Color.White;
        }
        private void menuBar_menuPlaylist_DropDownClosed(object sender, EventArgs e)
        {
            this.menuBar_menuPlaylist.ForeColor = Color.White;
        }

        // Tools
        private void menuBar_menuTools_MouseEnter(object sender, EventArgs e)
        {
            this.menuBar_menuTools.ForeColor = Color.Black;
        }
        private void menuBar_menuTools_MouseLeave(object sender, EventArgs e)
        {
            if (!menuBar_menuTools.Pressed) this.menuBar_menuTools.ForeColor = Color.White;
        }
        private void menuBar_menuTools_DropDownClosed(object sender, EventArgs e)
        {
            this.menuBar_menuTools.ForeColor = Color.White;
        }

        // Help
        private void menuBar_menuHelp_MouseEnter(object sender, EventArgs e)
        {
            this.menuBar_menuHelp.ForeColor = Color.Black;
        }
        private void menuBar_menuHelp_MouseLeave(object sender, EventArgs e)
        {
            if (!menuBar_menuHelp.Pressed) this.menuBar_menuTools.ForeColor = Color.White;
        }
        private void menuBar_menuHelp_DropDownClosed(object sender, EventArgs e)
        {
            this.menuBar_menuHelp.ForeColor = Color.White;
        }

    }
}
