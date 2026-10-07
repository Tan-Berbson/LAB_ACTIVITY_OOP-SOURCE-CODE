using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tan_OOPLab3.Models
{
    public class POS
    {
        // Admin account Class
        public class Accounts
        {
            public string username = "admin";
            public string password = "123";

            // username validation
            public string Username
            {
                get
                { 
                 return username;
                }
                set
                {
                    if(value == "")
                    {
                        Console.WriteLine("USERNAME MUST NOT BE EMTY!!");
                    }
                    else
                    {
                        value = username;
                    }
                }
            }
            // password validation
            public string Password
            {
                get
                {
                    return password;
                }
                set
                {
                    if(value == "")
                    {
                        Console.WriteLine("PASSWORD MUST NOT BE EMTY!!");
                    }
                }
            }
            //Admin Account Constructor
            public Accounts(string Username, string Password)
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
            string InputUsername = Console.ReadLine();

            Console.Write("Password: ");
            string InputPassword = Console.ReadLine();

            Accounts acc = new Accounts(InputUsername, InputPassword);
            if (acc.username == "admin" && acc.password == "123")
            {
                // Successful Login
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Log In Admin Successfully!");
                Console.ResetColor();
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
    }
}
