using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class clsUser 
    {
        private int _user_id;
        private string _username;
        private string _password;
        private int _isAdmin;

        public clsUser(string username, string password)
        {
            _username = username;
            _password = password;
        }

        public clsUser(int user_id, string username, string password, int isAdmin)
        {
            _user_id = user_id;
            _username = username;
            _password = password;
            _isAdmin = isAdmin;
        }

        public int User_id { get => _user_id; set => _user_id = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public int IsAdmin { get => _isAdmin; set => _isAdmin = value; }
    }
}
