using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment58
{
    public class PasswordValidator
    {
        public bool isValid(string password)
        {
            if (password.Any(char.IsUpper) && (password.Length >= 8) && password.Any(char.IsDigit))
            {
                return true;
            }
            return false;
        }
    }
}
