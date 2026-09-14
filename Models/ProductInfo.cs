
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Tan_OOPLab3.Models
{
    // Accounts Class
    // Multilevel Inheritance
    public class AuthorizeAccounts
    {
        public string AdminName = "admin";
        public string AdminPassword = "123";

        public string CashierName = "cashier";
        public string CashierPassword = "123";

        public string Login(string username, string password)
        {
            if (username == AdminName && password == AdminPassword)
            {
                // Return the user's role after successful login
                return "Admin";
            }

            if (username == CashierName && password == CashierPassword)
            {
                // Return the user's role after successful login
                return "Cashier";
            }

            return "Invalid";
        }
    }
    // Product info class that inherits from AuthorizeAccounts
    public class ProductInfo : AuthorizeAccounts
    {
        public int Id;
        public string Category;

        protected string _Name;
        protected int _Price;
        // Product name property with validation
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Product name cannot be empty.");
                }
                else
                {
                    _Name = value;
                }
            }
        }
        // Product price property with validation
        public int Price
        {
            get
            {
                return _Price;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Price must be greater than 0.");
                }
                else
                {
                    _Price = value;
                }
            }
        }

        // Product Info constructor
        public ProductInfo(int id, string name, int price, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }
    }

    // Drink product class that inherits from ProductInfo
    // Hierarchical Inheritance
    public class ProductDrinks : ProductInfo
    {
        public ProductDrinks(int id, string drinkName, int drinkPrice)
            : base(id, drinkName, drinkPrice, "Drink")
        {
        }
    }
    // Food product class that inherits from ProductInfo
    // Hierarchical Inheritance
    public class ProductFood : ProductInfo
    {
        public ProductFood(int id, string foodName, int foodPrice)
            : base(id, foodName, foodPrice, "Food")
        {
        }
    }
}
