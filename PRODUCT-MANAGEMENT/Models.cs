using System;

namespace Tan_OOPLab3.PRODUCT_MANAGEMENT
{
    public class Models
    {
        // Stores account details.
        public class Accounts
        {
            private string username;
            private string password;

            public string Username
            {
                get
                {
                    return username;
                }
                //validation
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        Console.WriteLine("  [ ERROR ] Username cannot be empty.");
                    }
                    else
                    {
                        username = value;
                    }
                }
            }


            public string Password
            {
                get
                {
                    return password;
                }
                //validation
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        Console.WriteLine("  [ ERROR ] Password cannot be empty.");
                    }
                    else
                    {
                        password = value;
                    }
                }
            }
        }
        // AuthorizeAccounts Constructor
        public class AuthorizeAccounts : Accounts
        {
            public AuthorizeAccounts(string username, string password)
            {
                Username = username;
                Password = password;
            }
        }
        // Stores product details.
        public class Products
        {
            private string productName;
            private int productPrice;

            public string ProductName
            {
                get
                {
                    return productName;
                }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        Console.WriteLine("  [ ERROR ] Product name cannot be empty.");
                    }
                    else
                    {
                        productName = value;
                    }
                }
            }

            public int ProductPrice
            {
                get
                {
                    return productPrice;
                }
                set
                {
                    if (value <= 0)
                    {
                        Console.WriteLine("  [ ERROR ] Product price must be greater than zero.");
                    }
                    else
                    {
                        productPrice = value;
                    }
                }
            }
        }
    }
}
