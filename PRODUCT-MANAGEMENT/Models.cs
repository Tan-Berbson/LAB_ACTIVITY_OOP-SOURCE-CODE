using System;

namespace Tan_OOPLab3.PRODUCT_MANAGEMENT
{
    public class Models
    {
        // Stores account details.
        public class Accounts
        {
           //fields
            private string username;
            private string password;

            // Property for accessing and validating the user's username.
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
            // Property for accessing and validating the user's password.
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
            // Property for accessing and validating the Product name.
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
            // Property for accessing and validating the Product price.
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
