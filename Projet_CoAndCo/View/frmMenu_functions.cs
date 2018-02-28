using System;
using System.Windows.Forms;

namespace Projet_CoAndCo
{
    public partial class frmMenu : Form
    {
        // Display admin only menu
        private void ShowMenuAdmin(Boolean display)
        {
            menuBar_menuTools.Visible = display;
        }

        // Display member menu
        private void ShowMenuMember(Boolean display)
        {
            menuBar_fichier_itemNewPlaylist.Visible = display;
            menuBar_fichier_separator1.Visible = display;
            menuBar_fichier_itemAddPath.Visible = display;
            menuBar_fichier_itemAddFic.Visible = display;
            menuBar_fichier_itemAddMedia.Visible = display;
            menuBar_fichier_separator2.Visible = display;
            menuBar_fichier_itemAddExemplaire.Visible = display;
            menuBar_fichier_itemDeleteExemplaire.Visible = display;
            menuBar_fichier_separator3.Visible = display;
            menuBar_menuMedia.Visible = display;
            menuBar_menuPlaylist.Visible = display;
        }

        // Display menu depending on type user 
        private void ShowMenus(int typeUser)
        {
            switch (typeUser)
            {
                case 1: // Member
                    ShowMenuMember(true);
                    ShowMenuAdmin(false);
                    break;
                case 2: // Admin
                    ShowMenuMember(true);
                    ShowMenuAdmin(true);
                    break;
                default: // User
                    ShowMenuMember(false);
                    ShowMenuAdmin(false);
                    break;
            }
            menuBar_btnConnection.Text = SetButtonConnectionText(typeUser);
            menuBar_txtMemberName.Text = SetTxtBoxMemberNameText(typeUser);
        }

        private string SetButtonConnectionText(int typeUser)
        {
            string connect = "Connexion";
            string disconnect = "Déconnexion";
            return (typeUser == 0) ? connect : disconnect;
        }

        private string SetTxtBoxMemberNameText(int typeUser)
        {
            string connect = "unknow user";
            string disconnect = "Member";
            return (typeUser == 0) ? connect : disconnect;
        }
    }
       
    
}