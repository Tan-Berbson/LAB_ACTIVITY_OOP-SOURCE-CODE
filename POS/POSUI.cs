using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Tan_OOPLab3.POS
{
    public class POSUI : Models
    {
        private Products product1;
        private Products product2;
        private Products product3;
        private Products product4;
        private Products addProduct1;
        private Products addProduct2;

        // Products static data
        public POSUI()
        {
            product1 = new Products { ProductName = "Chicken joy", ProductPrice = 199 };
            product2 = new Products { ProductName = "Hamburger", ProductPrice = 100 };
            product3 = new Products { ProductName = "Hotdogs", ProductPrice = 100 };
            product4 = new Products { ProductName = "Footlong", ProductPrice = 100 };

            addProduct1 = null;
            addProduct2 = null;
        }


        // Login method
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
                PrintSuccess("  [ INFO ] Login Successful: Admin");
                Console.ReadKey();
                AdminDashboard();
            }
            else if (username == acc2.Username && password == acc2.Password)
            {
                PrintSuccess("  [ INFO ] Login Successful: Cashier");
                Console.ReadKey();
                CashierDashboard();
            }
            else
            {
                PrintError("  [ ERROR ] Invalid Login");
                Console.ReadKey();
                Login();
            }
        }

        // Admin dashboard method
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
                        PrintError("\n  [ ERROR ] Invalid Choice");
                        Console.ReadKey();
                        AdminDashboard();
                        break;
                }
            }
            else
            {
                PrintError("\n  [ ERROR ] Please enter a valid number");
                Console.ReadKey();
                AdminDashboard();
            }
        }

        // View product method
        public void ViewProduct()
        {
            Console.Clear();

            Console.WriteLine("┌───────┬────────────────────┬───────────────┐");
            Console.WriteLine("│                PRODUCT LIST                │");
            Console.WriteLine("├───────┬────────────────────┬───────────────┤");
            Console.WriteLine("│ NO.   │ PRODUCT NAME       │ PRICE         │");
            Console.WriteLine("├───────┼────────────────────┼───────────────┤");

            Console.WriteLine($"│ [1]   │ {product1.ProductName,-18} │ Php {product1.ProductPrice,-9} │");
            Console.WriteLine($"│ [2]   │ {product2.ProductName,-18} │ Php {product2.ProductPrice,-9} │");
            Console.WriteLine($"│ [3]   │ {product3.ProductName,-18} │ Php {product3.ProductPrice,-9} │");
            Console.WriteLine($"│ [4]   │ {product4.ProductName,-18} │ Php {product4.ProductPrice,-9} │");

            if (addProduct1 != null)
            {
                Console.WriteLine($"│ [5]   │ {addProduct1.ProductName,-18} │ Php {addProduct1.ProductPrice,-9} │");
            }

            if (addProduct2 != null)
            {
                Console.WriteLine($"│ [6]   │ {addProduct2.ProductName,-18} │ Php {addProduct2.ProductPrice,-9} │");
            }

            Console.WriteLine("└───────┴────────────────────┴───────────────┘");

            Console.WriteLine("\n  Press any key to continue...");
            Console.ReadKey();

            AdminDashboard();
        }

        // Manage product method
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
                        PrintError("\n  [ ERROR ] Invalid Choice");
                        Console.ReadKey();
                        ManageProduct();
                        break;
                }
            }
            else
            {
                PrintError("\n  [ ERROR ] Please enter a valid number");
                Console.ReadKey();
                ManageProduct();
            }
        }

        // Cashier dashboard method
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
                        PrintError("\n  [ ERROR ] Invalid Choice");
                        Console.ReadKey();
                        CashierDashboard();
                        break;
                }
            }
            else
            {
                PrintError("\n  [ ERROR ] Please enter a valid number");
                Console.ReadKey();
                CashierDashboard();
            }
        }

        public void Sell()
        {

        }

        // Edit product method
        public void EditProduct()
        {
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("               EDIT PRODUCT");
            Console.WriteLine("========================================");

            Console.WriteLine(String.Format(
                "  {0,-5} | {1,-15} | {2,10}",
                "ID", "PRODUCT NAME", "PRICE"));

            Console.WriteLine("----------------------------------------");

            Console.WriteLine(String.Format(
                "  {0,-5} | {1,-15} | Php {2,6}",
                "[1]", product1.ProductName, product1.ProductPrice));

            Console.WriteLine(String.Format(
                "  {0,-5} | {1,-15} | Php {2,6}",
                "[2]", product2.ProductName, product2.ProductPrice));

            Console.WriteLine(String.Format(
                "  {0,-5} | {1,-15} | Php {2,6}",
                "[3]", product3.ProductName, product3.ProductPrice));

            Console.WriteLine(String.Format(
                "  {0,-5} | {1,-15} | Php {2,6}",
                "[4]", product4.ProductName, product4.ProductPrice));

            if (addProduct1 != null)
            {
                Console.WriteLine(String.Format(
                    "  {0,-5} | {1,-15} | Php {2,6}",
                    "[5]", addProduct1.ProductName, addProduct1.ProductPrice));
            }

            if (addProduct2 != null)
            {
                Console.WriteLine(String.Format(
                    "  {0,-5} | {1,-15} | Php {2,6}",
                    "[6]", addProduct2.ProductName, addProduct2.ProductPrice));
            }

            Console.WriteLine("========================================");
            Console.Write("  Select which product to edit: ");

            int select;

            while (!int.TryParse(Console.ReadLine(), out select))
            {
                PrintError("  [ ERROR ] Invalid input. Please enter a number.");
                Console.Write("  Select which product to edit: ");
            }

            Console.WriteLine("----------------------------------------");

            string newName;
            int newPrice;

            switch (select)
            {
                case 1:
                    Console.Write("  New Product Name: ");
                    newName = Console.ReadLine();

                    while (string.IsNullOrWhiteSpace(newName))
                    {
                        PrintError("  [ ERROR ] Name cannot be empty.");
                        Console.Write("  New Product Name: ");
                        newName = Console.ReadLine();
                    }

                    product1.ProductName = newName;

                    Console.Write("  New Product Price: ");

                    while (!int.TryParse(Console.ReadLine(), out newPrice))
                    {
                        PrintError("  [ ERROR ] Invalid price. Must be a number.");
                        Console.Write("  New Product Price: ");
                    }

                    product1.ProductPrice = newPrice;

                    PrintSuccess("\n  [ INFO ] Product Updated Successfully!");
                    Console.ReadKey();
                    ManageProduct();
                    break;

                case 2:
                    Console.Write("  New Product Name: ");
                    newName = Console.ReadLine();

                    while (string.IsNullOrWhiteSpace(newName))
                    {
                        PrintError("  [ ERROR ] Name cannot be empty.");
                        Console.Write("  New Product Name: ");
                        newName = Console.ReadLine();
                    }

                    product2.ProductName = newName;

                    Console.Write("  New Product Price: ");

                    while (!int.TryParse(Console.ReadLine(), out newPrice))
                    {
                        PrintError("  [ ERROR ] Invalid price. Must be a number.");
                        Console.Write("  New Product Price: ");
                    }

                    product2.ProductPrice = newPrice;

                    PrintSuccess("\n  [ INFO ] Product Updated Successfully!");
                    Console.ReadKey();
                    ManageProduct();
                    break;

                case 3:
                    Console.Write("  New Product Name: ");
                    newName = Console.ReadLine();

                    while (string.IsNullOrWhiteSpace(newName))
                    {
                        PrintError("  [ ERROR ] Name cannot be empty.");
                        Console.Write("  New Product Name: ");
                        newName = Console.ReadLine();
                    }

                    product3.ProductName = newName;

                    Console.Write("  New Product Price: ");

                    while (!int.TryParse(Console.ReadLine(), out newPrice))
                    {
                        PrintError("  [ ERROR ] Invalid price. Must be a number.");
                        Console.Write("  New Product Price: ");
                    }

                    product3.ProductPrice = newPrice;

                    PrintSuccess("\n  [ INFO ] Product Updated Successfully!");
                    Console.ReadKey();
                    ManageProduct();
                    break;

                case 4:
                    Console.Write("  New Product Name: ");
                    newName = Console.ReadLine();

                    while (string.IsNullOrWhiteSpace(newName))
                    {
                        PrintError("  [ ERROR ] Name cannot be empty.");
                        Console.Write("  New Product Name: ");
                        newName = Console.ReadLine();
                    }

                    product4.ProductName = newName;

                    Console.Write("  New Product Price: ");

                    while (!int.TryParse(Console.ReadLine(), out newPrice))
                    {
                        PrintError("  [ ERROR ] Invalid price. Must be a number.");
                        Console.Write("  New Product Price: ");
                    }

                    product4.ProductPrice = newPrice;

                    PrintSuccess("\n  [ INFO ] Product Updated Successfully!");
                    Console.ReadKey();
                    ManageProduct();
                    break;

                case 5:
                    if (addProduct1 == null)
                    {
                        PrintError("\n  [ ERROR ] Invalid Select");
                        Console.ReadKey();
                        EditProduct();
                        break;
                    }

                    Console.Write("  New Product Name: ");
                    newName = Console.ReadLine();

                    while (string.IsNullOrWhiteSpace(newName))
                    {
                        PrintError("  [ ERROR ] Name cannot be empty.");
                        Console.Write("  New Product Name: ");
                        newName = Console.ReadLine();
                    }

                    addProduct1.ProductName = newName;

                    Console.Write("  New Product Price: ");

                    while (!int.TryParse(Console.ReadLine(), out newPrice))
                    {
                        PrintError("  [ ERROR ] Invalid price. Must be a number.");
                        Console.Write("  New Product Price: ");
                    }

                    addProduct1.ProductPrice = newPrice;

                    PrintSuccess("\n  [ INFO ] Product Updated Successfully!");
                    Console.ReadKey();
                    ManageProduct();
                    break;

                case 6:
                    if (addProduct2 == null)
                    {
                        PrintError("\n  [ ERROR ] Invalid Select");
                        Console.ReadKey();
                        EditProduct();
                        break;
                    }

                    Console.Write("  New Product Name: ");
                    newName = Console.ReadLine();

                    while (string.IsNullOrWhiteSpace(newName))
                    {
                        PrintError("  [ ERROR ] Name cannot be empty.");
                        Console.Write("  New Product Name: ");
                        newName = Console.ReadLine();
                    }

                    addProduct2.ProductName = newName;

                    Console.Write("  New Product Price: ");

                    while (!int.TryParse(Console.ReadLine(), out newPrice))
                    {
                        PrintError("  [ ERROR ] Invalid price. Must be a number.");
                        Console.Write("  New Product Price: ");
                    }

                    addProduct2.ProductPrice = newPrice;

                    PrintSuccess("\n  [ INFO ] Product Updated Successfully!");
                    Console.ReadKey();
                    ManageProduct();
                    break;

                default:
                    PrintError("\n  [ ERROR ] Invalid Select");
                    Console.ReadKey();
                    EditProduct();
                    break;
            }
        }

        // Add product method
        public void AddProduct()
        {
            Console.Clear();

            Console.WriteLine("========================================");
            Console.WriteLine("               ADD PRODUCT");
            Console.WriteLine("========================================");

            if (addProduct1 != null && addProduct2 != null)
            {
                PrintError("  [ ERROR ] Maximum custom products reached (2 allowed).");
                Console.ReadKey();
                ManageProduct();
                return;
            }

            Products newProduct = new Products();

            Console.Write("  New Product Name: ");
            string newName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(newName))
            {
                PrintError("  [ ERROR ] Name cannot be empty.");
                Console.Write("  New Product Name: ");
                newName = Console.ReadLine();
            }

            newProduct.ProductName = newName;

            Console.Write("  New Product Price: ");
            int newPrice;

            while (!int.TryParse(Console.ReadLine(), out newPrice))
            {
                PrintError("  [ ERROR ] Invalid price. Must be a number.");
                Console.Write("  New Product Price: ");
            }

            newProduct.ProductPrice = newPrice;

            if (addProduct1 == null)
            {
                addProduct1 = newProduct;
            }
            else
            {
                addProduct2 = newProduct;
            }

            PrintSuccess("\n  [ INFO ] Product Saved Successfully!");
            Console.ReadKey();

            ManageProduct();
        }

        // Password masking input
        public static string ReadPassword()
        {
            string pass = "";
            ConsoleKeyInfo key;

            while ((key = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            {
                if (key.Key != ConsoleKey.Backspace)
                {
                    pass += key.KeyChar;
                    Console.Write("*");
                }
                else if (pass.Length > 0)
                {
                    pass = pass.Substring(0, pass.Length - 1);
                    Console.Write("\b \b");
                }
            }

            Console.WriteLine();

            return pass;
        }

        // Success print method
        private void PrintSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        // Error print method
        private void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}