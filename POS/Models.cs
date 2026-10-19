using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tan_OOPLab3.POS
{
    public class Models
    {
        public class Accounts
        {
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
            public AuthorizeAccount(string AccUsername, string AccPassword)
            {
                Username = AccUsername;
                Password = AccPassword;
            }
        }

        public class Products
        {
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

            public int ProductQuantity;

            public int productQuantity
            {
                get
                {
                    return ProductQuantity;
                }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("PRODUCT QUANTITY MUST NOT BE NEGATIVE!!");
                    }
                    else
                    {
                        ProductQuantity = value;
                    }
                }
            }
        }

    }
    
}
