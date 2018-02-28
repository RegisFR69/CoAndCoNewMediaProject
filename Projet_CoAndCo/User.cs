using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_CoAndCo
{
    class User
    {
        private int _idUser;
        private string _password;
        private string _login;
        private int _idTypeUser;
        private string _labelTypeUser;

        // Accessors
        public int GetIdUser() { return this._idUser; }
        public string GetPassword() { return this._password; }
        public string GetLogin() { return this._login; }
        public int GetIdTypeUser() { return this._idTypeUser; }
        public string GetLabelTypeUser() { return this._labelTypeUser; }

        // Mutators
        private void SetIdUser(int id) { this._idUser = id; }
        public void SetPassword(string password) { this._password = password; }
        public void SetLogin(string login) { this._login = login; }
        private void SetIdTypeUser(int id) { this._idTypeUser = id; }
        public void SetLabelTypeUser(string label) { this._labelTypeUser = label; }

        // Constructor
        public User(int id = 0, int id_type = 0)
        {
            this.SetIdUser(id);
            this.SetIdTypeUser(id_type);
        }
    }
}
