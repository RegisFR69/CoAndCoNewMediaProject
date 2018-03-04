using System;
using System.Collections;
using System.Data;

namespace Projet_CoAndCo
{
    public partial class frmLogin
    {
        // renvoie un tableau de string contenant la liste des logins dans User
        private ArrayList UserLoginList()
        {
            ArrayList userLoginList = new ArrayList();
            DataTable userTable = coAndCoDBDataSetLogin.Tables["User"];
            foreach (DataRow Row in userTable.Rows)
            {
                string login = (string)Row[2];
                userLoginList.Add(login.Trim());
            }
            return userLoginList;
        }

        // renvoie vrai si login et password correspondent
        private Boolean userValidation(User user)
        {
            DataRow row = coAndCoDBDataSetLogin.Tables["User"].Rows[user.getIdUser()];
            string login = ((string)row[2]).Trim();
            string password = ((string)row[1]).Trim();
            if ( user.getLogin() == login && user.getPassword() == password)
            {
                return true;
            }
            return false;
        }

        private Boolean ValidateConnexion()
        {
            if (txtPass2_Login.Visible)
            {
                if (txtPass_Login.Text == txtPass2_Login.Text)
                {
                    lblidUser.Text = addNewUser();
                    return true;
                }
                else
                {
                    lblTitre_Login.Text = "mots de passe différents !";
                    txtPass_Login.Text = "";
                    txtPass2_Login.Text = "";
                }
            }
            else
            {
                User user = new User(idUser);
                user.setLogin(txtId_Login.Text);
                user.setPassword(txtPass_Login.Text);

                if (userValidation(user))
                {
                    lblidUser.Text = idUser.ToString();
                    return true;
                }
                else
                {
                    lblTitre_Login.Text = "mot de passe érroné !";
                    txtPass_Login.Text = "";
                }
            }
            return false;
        }

        private string addNewUser()
        {
            CoAndCoDBDataSet.UserRow newUserRow;
            newUserRow = coAndCoDBDataSetLogin.User.NewUserRow();
            newUserRow.id_user = idUser;
            newUserRow.password = txtPass_Login.Text;
            newUserRow.login = txtId_Login.Text;
            newUserRow.id_type_user = 1;
            this.coAndCoDBDataSetLogin.User.Rows.Add(newUserRow);
            this.userTableAdapter.Update(this.coAndCoDBDataSetLogin.User);
            return idUser.ToString();
        }

        private void NewUser(Boolean value)
        {
            lblTitre_Login.Visible = value;
            lblPass2_Login.Visible = value;
            txtPass2_Login.Visible = value;
        }

    }  
}