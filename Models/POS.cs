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
            public string username;
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
                        username = value;
                    }
                }
            }

        }
        // AccountPassword Class
        public  class AccountPassword : AccountUsername
        {
            public string password;
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
                    else
                    {
                        password = value;
                    }
                }
            }
           
           
        }
        // Accounts constructor
        public class AuthorizeAccount : AccountPassword
        {
            public AuthorizeAccount(string AccUsername, string AccPassword)
            {
                username = AccUsername;
                password = AccPassword;
            }
        }

       
       
    }
}
