using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace Projet_CoAndCo
{
    public partial class frmLogin
    {
        // renvoie un tableau de string contenant la liste des logins dans User
        private ArrayList UserLoginList()
        {
            ArrayList userLoginList = new ArrayList();
            DataTable userTable = dataSetUser.Tables["User"];
            foreach (DataRow Row in userTable.Rows)
            {
                string login = (string)Row[1];// column 'login'
                userLoginList.Add(login.Trim());
            }
            return userLoginList;
        }

        private Boolean loginValidation(User user)
        {
            user.setLogin(txtLogin.Text);
            ArrayList loginList = UserLoginList();
            if (loginList.Contains(txtLogin.Text))
            {
                user.setIdUser(loginList.IndexOf(txtLogin.Text));
                return true;
            }
            else
            {
                user.setIdUser(loginList.Count);
                return false;
            }
        }


        // renvoie vrai si login et password correspondent
        private Boolean userValidation(User user)
        {
            DataRow row = dataSetUser.Tables["User"].Rows[user.getIdUser()];
            string login = ((string)row[1]).Trim();
            string password = ((string)row[2]).Trim();
            if ( user.getLogin() == login && user.getPassword() == password)
            {
                user.setIdTypeUser((int)row[3]);
                return true;
            }
            return false;
        }

        private Boolean ValidateConnexion(User user)
        {
            if (txtPassword2.Visible)
            {
                if (txtPassword.Text == txtPassword2.Text)
                {
                    addNewUser(user);
                    return true;
                }
                else
                {
                    lblTitre_Login.Text = "mots de passe différents !";
                    txtPassword.Text = "";
                    txtPassword2.Text = "";
                }
            }
            else
            {
                user.setPassword(txtPassword.Text);

                if (userValidation(user))
                {
                    return true;
                }
                else
                {
                    lblTitre_Login.Text = "mot de passe érroné !";
                    txtPassword.Text = "";
                }
            }
            return false;
        }

        private void addNewUser(User user)
        {
            Data.DataSet1.UserRow newUserRow;
            newUserRow = dataSetUser.User.NewUserRow();
            newUserRow.id_user = user.getIdUser();
            user.setPassword(txtPassword.Text);
            newUserRow.password = user.getPassword();
            newUserRow.login = user.getLogin();
            user.setIdTypeUser(1);
            newUserRow.id_type_user = 1;
            this.dataSetUser.User.Rows.Add(newUserRow);
            this.userTableAdapter.Update(this.dataSetUser.User);
        }

        private void newUser(Boolean value)
        {
            lblTitre_Login.Visible = value;
            lblPass2_Login.Visible = value;
            txtPassword2.Visible = value;
        }
    }  
}