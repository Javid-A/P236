using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers__Namespace__DLL
{
    internal class User
    {
        string _username;
        string _password;
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length > 6)
                {
                    _username = value;
                }
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (CheckPassword(value))
                {
                    _password = value;
                }
            }
        }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public User()
        {

        }

        public bool CheckPassword(string pw)
        {
            bool result = default;
            if (pw.Length >= 8)
            {
                bool hasDigit = false;
                bool hasUpper = false;
                bool hasLower = false;
                foreach (char letter in pw)
                {
                    if (char.IsDigit(letter))
                    {
                        hasDigit = true;
                    }
                    else if (char.IsUpper(letter))
                    {
                        hasUpper = true;
                    }
                    else if (char.IsLower(letter))
                    {
                        hasLower = true;
                    }
                }

                result = hasDigit && hasUpper && hasLower;
                
            }
            return result;
        }
    }
}
