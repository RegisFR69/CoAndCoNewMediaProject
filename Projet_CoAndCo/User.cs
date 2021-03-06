﻿using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projet_CoAndCo
{
    public class User
    {
        private int _idUser;
        private string _password;
        private string _login;
        private int _idTypeUser;
        private string _labelTypeUser;

        // Accessors
        public int getIdUser() { return this._idUser; }
        public string getPassword() { return this._password; }
        public string getLogin() { return this._login; }
        public int getIdTypeUser() { return this._idTypeUser; }
        public string getLabelTypeUser() { return this._labelTypeUser; }

        // Mutators
        public void setIdUser(int id) { this._idUser = id; }
        public void setPassword(string password) { this._password = password; }
        public void setLogin(string login) { this._login = login; }
        public void setIdTypeUser(int id) { this._idTypeUser = id; }
        public void setLabelTypeUser(string label) { this._labelTypeUser = label; }

        // Constructor
        public User()
        {
            this.setIdUser(0);
            this.setPassword("");
            this.setLogin("unknow user");
            this.setIdTypeUser(0);
            this.setLabelTypeUser("user");
        }
        public User(int id)
        {
            this.setIdUser(id);
        }
    }
}
