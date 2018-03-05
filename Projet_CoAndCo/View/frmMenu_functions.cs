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
            int id = user.getIdTypeUser();
            //int typeUser = user.getIdTypeUser;
            switch (id)
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
            menuBar_btnConnection.Text = SetButtonConnectionText(id);
            menuBar_txtMemberName.Text = user.getLogin();

        }

        private string SetButtonConnectionText(int idTypeUser)
        {
            //string connect = "Connexion";
            //string disconnect = "Déconnexion";
            return (idTypeUser == 0) ? CONNECT : DISCONNECT;
        }

        private User CnxUser(int id)
        {
            User user = new User(id);
            user.setPassword(coAndCoDBDataSet.Tables["User"].Rows[id][1].ToString());
            user.setLogin(coAndCoDBDataSet.Tables["User"].Rows[id][2].ToString());
            int tid = Convert.ToInt32(coAndCoDBDataSet.Tables["User"].Rows[id][3].ToString());
            user.setIdTypeUser(tid);
            user.setLabelTypeUser(coAndCoDBDataSet.Tables["type_User"].Rows[tid][1].ToString());
            return user;
        }

        private ArrayList UserLoginList()
        {
            ArrayList userLoginList = new ArrayList();
            DataTable userTable = coAndCoDBDataSet.Tables["User"];
            foreach( DataRow Row in userTable.Rows )
            {
                userLoginList.Add(Row[2]);
            }
            return userLoginList;
        }


    }

    
}