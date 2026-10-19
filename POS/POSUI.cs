using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tan_OOPLab3.POS
{
    public  class POSUI : Models
    {
        public void Login()
        {
            Accounts acc = new Accounts();
            Console.Clear();
            Console.WriteLine("Dashboard");
            Console.WriteLine("USERNAME:");
            string username = Console.ReadLine();
            Console.WriteLine("PASSWORD");
            string password = Console.ReadLine();
            if (username == acc.Username && password == acc.Password)
            {
                Console.WriteLine("Login Succesfull");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Invalid Login");
                Console.ReadKey();
                Login();
            }

        }
        public void AdminDashboard()
        {
            Console.WriteLine("Dashboard");
            Console.WriteLine("[1] view products");
            Console.WriteLine("[2] Manage Products");
            Console.WriteLine("[3] logout");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ViewProduct();
                    break;
                case 2:
                    ManageProduct();
                    break;
                case 3:
                    Login();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
        public void CashierDashboard()
        {
            Console.WriteLine("Cashier Dashboard");
            Console.WriteLine("[1] sell Products");
            Console.WriteLine("[2] Logout");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Sell();
                    break;
                case 2:
                    Login();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
           

        }
        public void Sell()
        {

        }

        public void ViewProduct()
        {

        }
        public void ManageProduct()
        {
            Console.WriteLine("Manage Product");
            Console.WriteLine("[1] Edit Product");
            Console.WriteLine("[2] Add Product");
            Console.WriteLine("[3] Back");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    EditProduct();
                    break;
                case 2:
                    AddProduct();
                    break;
                case 3:
                    AdminDashboard();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
        public void EditProduct()
        {
            ViewProduct();
        }
        public void AddProduct()
        {
            ViewProduct();
        }


    }
}
