using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tan_OOPLab3.PRODUCT_MANAGEMENT
{
    internal class Models
    {
        // accounts fields
        public class Accounts
        {
            // accounts attributes
            public string Username;
            public string username
            {
                get
                {
                    return Username;
                }
                set
                {
                    if (value == "")
                    {
                        Console.WriteLine("USERNAME MUST NOT BE EMTY!!");
                    }
                    else
                    {
                        Username = value;
                    }
                }
            }
            // accounts attributes
            public string Password;
            public string password
            {
                get
                {
                    return Password;
                }
                set
                {
                    if (value == "")
                    {
                        Console.WriteLine("PASSWORD MUST NOT BE EMTY!!");
                    }
                    else
                    {
                        Password = value;
                    }
                }
            }


        }
        public class AuthorizeAccount : Accounts
        {
            // constructor
            public AuthorizeAccount(string AccUsername, string AccPassword)
            {
                Username = AccUsername;
                Password = AccPassword;
            }
        }
        // product fields
        public class Products
        {
            // product attribute
            public string ProductName;

            public string productName
            {
                get
                {
                    return ProductName;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        Console.WriteLine("PRODUCT NAME MUST NOT BE EMPTY!!");
                    }
                    else
                    {
                        ProductName = value;
                    }
                }
            }

            public int ProductPrice;
            // product attributes
            public int productPrice
            {
                get
                {
                    return ProductPrice;
                }
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("PRODUCT PRICE MUST BE GREATER THAN ZERO!!");
                    }
                    else
                    {
                        ProductPrice = value;
                    }
                }
            }
            


        }
    }
}
