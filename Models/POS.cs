using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tan_OOPLab3.Models
{
    public class POS
    {
        //  AccountUsername Class
        public class AccountUsername
        {
            public string username = "admin";
            // username validation
            public string Username
            {
                get
                {
                    return username;
                }
                set
                {
                    if (value == "")
                    {
                        Console.WriteLine("USERNAME MUST NOT BE EMTY!!");
                    }
                    else
                    {
                        value = username;
                    }
                }
            }

        }
        // AccountPassword Class
        public class AccountPassword : AccountUsername
        {
            public string password = "123";
            // password validation
            public string Password
            {
                get
                {
                    return password;
                }
                set
                {
                    if (value == "")
                    {
                        Console.WriteLine("PASSWORD MUST NOT BE EMTY!!");
                    }
                }
            }
            // Accounts constructor
            public AccountPassword(string  Username, string Password)
            {
                username = Username;
                password = Password;
            }
        }
       
        // Login Method
        public void Login()
        {
           
            Console.Clear();
            Console.WriteLine("=====================");
            Console.WriteLine("====== LOG IN =======");
            Console.WriteLine("=====================");
            Console.Write("Username: ");
            string username = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            AccountPassword acc = new AccountPassword(username, password);

            if (acc.username == "admin" && acc.password == "123")
            {
                // Successful Login
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Log In Admin Successfully!");
                Console.ResetColor();
                Console.ReadKey();
                Dashboard();
            }
            else
            {
                // Invalid Try Again
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Credentials Try Again");
                Console.ReadKey();
                Console.ResetColor();
                Login();
            }
        }
        // Admin dashboard
        public void Dashboard()
        {
            Console.Clear();
            Console.WriteLine("=====================");
            Console.WriteLine("===== DASHBOARD =====");
            Console.WriteLine("=====================");
            Console.WriteLine("[1] VIEW ALL PRODUCTS ");
            Console.WriteLine("[2] EDIT PRODUCTS ");
            Console.WriteLine("[3] SELL PRODUCTS");
            Console.WriteLine("[4] LOG OUT");

        }
    }
}
