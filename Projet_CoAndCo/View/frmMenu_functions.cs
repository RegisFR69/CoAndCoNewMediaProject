using System;
using System.Data;
using System.Collections;

namespace Projet_CoAndCo
{
    public partial class frmMenu
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
        private void ShowMenus(User user)
        {
            switch (user.getIdTypeUser())
            {
                case 1: // Member
                    ShowMenuMember(true);
                    ShowMenuAdmin(false);
                    break;
                case 2: // Admin
                case 3: // SuperAdmin
                    ShowMenuMember(true);
                    ShowMenuAdmin(true);
                    break;
                default: // User
                    ShowMenuMember(false);
                    ShowMenuAdmin(false);
                    break;
            }
            menuBar_btnConnection.Text = SetButtonConnectionText(user.getIdTypeUser());
            menuBar_txtMemberName.Text = user.getLogin();

        }

        private string SetButtonConnectionText(int idTypeUser)
        {
            return (idTypeUser == 0) ? CONNECT : DISCONNECT;
        }
    }

    
}