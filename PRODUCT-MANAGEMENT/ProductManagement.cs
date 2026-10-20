using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Tan_OOPLab3.PRODUCT_MANAGEMENT.Models;

namespace Tan_OOPLab3.PRODUCT_MANAGEMENT
{
    internal class ProductManagement
    {
        public void Login()
        {
            Accounts acc1 = new Accounts();
            acc1.Username = "admin";
            acc1.Password = "123";
            Accounts acc2 = new Accounts();
            acc2.Username = "cashier";
            acc2.Password = "123";

            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("          POS SYSTEM LOGIN");
            Console.WriteLine("========================================");

            Console.Write("  USERNAME: ");
            string username = Console.ReadLine();

            Console.Write("  PASSWORD: ");
            string password = ReadPassword();

            Console.WriteLine("----------------------------------------");

            if (username == acc1.Username && password == acc1.Password)
            {
                Console.WriteLine("  [ INFO ] Login Successful: Admin");
                Console.ReadKey();
                AdminDashboard();
            }
            else if (username == acc2.Username && password == acc2.Password)
            {
                Console.WriteLine("  [ INFO ] Login Successful: Cashier");
                Console.ReadKey();
                CashierDashboard();
            }
            else
            {
                Console.WriteLine("  [ ERROR ] Invalid Login");
                Console.ReadKey();
                Login();
            }
        }

        public void AdminDashboard()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("             ADMIN DASHBOARD");
            Console.WriteLine("========================================");
            Console.WriteLine("  [1] View Products");
            Console.WriteLine("  [2] Manage Products");
            Console.WriteLine("  [3] Logout");
            Console.WriteLine("----------------------------------------");
            Console.Write("  Enter Choice: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
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
                        Console.WriteLine("\n  [ ERROR ] Invalid Choice");
                        Console.ReadKey();
                        AdminDashboard();
                        break;
                }
            }
            else
            {
                Console.WriteLine("\n  [ ERROR ] Please enter a valid number");
                Console.ReadKey();
                AdminDashboard();
            }
        }

        public void ViewProduct()
        {
            
        }

        public void ManageProduct()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("             MANAGE PRODUCT");
            Console.WriteLine("========================================");
            Console.WriteLine("  [1] Edit Product");
            Console.WriteLine("  [2] Add Product");
            Console.WriteLine("  [3] Back");
            Console.WriteLine("----------------------------------------");
            Console.Write("  Select Choice: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
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
                        Console.WriteLine("\n  [ ERROR ] Invalid Choice");
                        Console.ReadKey();
                        ManageProduct();
                        break;
                }
            }
            else
            {
                Console.WriteLine("\n  [ ERROR ] Please enter a valid number");
                Console.ReadKey();
                ManageProduct();
            }
        }

        public void CashierDashboard()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("            CASHIER DASHBOARD");
            Console.WriteLine("========================================");
            Console.WriteLine("  [1] Sell");
            Console.WriteLine("  [2] Logout");
            Console.WriteLine("----------------------------------------");
            Console.Write("  Enter Choice: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Sell();
                        break;
                    case 2:
                        Login();
                        break;
                    default:
                        Console.WriteLine("\n  [ ERROR ] Invalid Choice");
                        Console.ReadKey();
                        CashierDashboard();
                        break;
                }
            }
            else
            {
                Console.WriteLine("\n  [ ERROR ] Please enter a valid number");
                Console.ReadKey();
                CashierDashboard();
            }
        }

        public void Sell()
        {

        }

        public void EditProduct()
        {
           
        }

        public void AddProduct()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("               ADD PRODUCT");
            Console.WriteLine("========================================");

            Products AddProduct1 = new Products();

            Console.Write("  New Product Name: ");
            string newName = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(newName))
            {
                Console.WriteLine("  [ ERROR ] Name cannot be empty.");
                Console.Write("  New Product Name: ");
                newName = Console.ReadLine();
            }
            AddProduct1.ProductName = newName;
            Console.Write("  New Product Price: ");
            int newPrice;
            while (!int.TryParse(Console.ReadLine(), out newPrice))
            {
                Console.WriteLine("  [ ERROR ] Invalid price. Must be a number.");
                Console.Write("  New Product Price: ");
            }
            AddProduct1.ProductPrice = newPrice;

            Console.WriteLine("\n  [ INFO ] Product Saved Successfully!");
            Console.ReadKey();
            ManageProduct();
        }

        public static string ReadPassword()
        {
            // deri i store ang password
            string pass = "";
            // mga key imo pindoton
            ConsoleKeyInfo key;

            // loop keys while typing and end if the key is enter
            while ((key = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            {
                // if ang key deli mag backspace mag print ng star 
                if (key.Key != ConsoleKey.Backspace)
                {
                    pass += key.KeyChar;
                    // Print a star for every letter typed
                    Console.Write("*");
                }
                // Handle Backspace 
                // if imo pindoton ang backspace ma remove ang pinka last nga letra
                else if (pass.Length > 0)
                {
                    pass = pass.Substring(0, pass.Length - 1);
                    //mao ni ang code para ma remove sad ang star
                    Console.Write("\b \b");
                }
            }
            Console.WriteLine();

            return pass;
        }
    }
}
