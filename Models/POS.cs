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
        public void Login()
        {
            Console.WriteLine("======LOG IN =======");
        }
    }
}
