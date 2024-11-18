using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment58
{
    public class UserRegistration
    {
        private PasswordValidator _passwordValidator;

        public UserRegistration()
        {
            _passwordValidator = new PasswordValidator();
        }
        public User RegisterUser(string username, string email, string password)
        {
            if (_passwordValidator.isValid(password))
            {
                Console.WriteLine("User registered successfully!");
                return new User(username, password, email);
            }
            Console.WriteLine("Password is too weak. It must be at least 8 characters long and contain an uppercase letter and a number.");
            return null;
        }

        public User RegisterUser()
        {
            System.Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            System.Console.Write("Enter your password:");
            string password = Console.ReadLine();
            System.Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            

            if (_passwordValidator.isValid(password))
            {
                Console.WriteLine("User registered successfully!");
                return new User(username, password, email);
            }
            Console.WriteLine("Password is too weak. It must be at least 8 characters long and contain an uppercase letter and a number.");
            return null;
        }
    }
}
