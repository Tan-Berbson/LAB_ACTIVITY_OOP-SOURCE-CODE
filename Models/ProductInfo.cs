
using System;

namespace Tan_OOPLab3.Models
{
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
                return "Admin";
            }

            if (username == CashierName && password == CashierPassword)
            {
                return "Cashier";
            }

            return "Invalid";
        }
    }

    public class ProductInfo : AuthorizeAccounts
    {
        public int Id;
        public string Category;

        protected string _Name;
        protected int _Price;

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

        public ProductInfo(int id, string name, int price, string category)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = category;
        }
    }

    public class ProductDrinks : ProductInfo
    {
        public ProductDrinks(int id, string drinkName, int drinkPrice)
            : base(id, drinkName, drinkPrice, "Drink")
        {
        }
    }

    public class ProductFood : ProductInfo
    {
        public ProductFood(int id, string foodName, int foodPrice)
            : base(id, foodName, foodPrice, "Food")
        {
        }
    }
}
