using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment58
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        private string _password;
        public string Password{
            get { return _password; }
            set {
                PasswordValidator passwordcheck = new PasswordValidator();
                if (!passwordcheck.isValid(value))
                {
                    return;
                }
                _password = value;
            }
        }
        public User(string Username, string Password, string Email)
        {
            this.Username = Username;
            this.Email = Email;
            PasswordValidator passwordcheck = new PasswordValidator();
            if (passwordcheck.isValid(Password))
            {
                _password = Password;
            }
            else
            {
                return;
            }            
        }
    }
}