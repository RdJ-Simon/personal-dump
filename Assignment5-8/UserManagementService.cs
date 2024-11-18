using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment58
{
    public class UserManagementService
    {
        public User[] users = new User[10];
        private int userIndex = 0;

        public void AddUser()
        {
            UserRegistration _userRegistration = new UserRegistration();

            System.Console.Write("Enter your username: ");
            string username = Console.ReadLine();
            System.Console.Write("Enter your password:");
            string password = Console.ReadLine();
            System.Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            User user = _userRegistration.RegisterUser(username, email, password);
            if ((userIndex < users.Length) && (user != null))
            {
                users[userIndex] = user;
                userIndex++;
                // return;
            }
            else{
                System.Console.WriteLine("Not enough space for new users!");
            }
        }

        public void AddUser(string username, string password, string email)
        {
            UserRegistration _userRegistration = new UserRegistration();

            User user = _userRegistration.RegisterUser(username, email, password);
            if ((userIndex < users.Length) && (user != null))
            {
                users[userIndex] = user;
                userIndex++;
                return;
            }
            else{
                System.Console.WriteLine("Not enough space for new users!");
            }
        }
    }
}
