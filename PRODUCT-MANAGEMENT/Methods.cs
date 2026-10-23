using System;
using System.Text;
using static Tan_OOPLab3.PRODUCT_MANAGEMENT.Models;

namespace Tan_OOPLab3.PRODUCT_MANAGEMENT
{
    public class Methods
    {
        // Fixed product objects.
        private Products product1;
        private Products product2;
        private Products product3;
        private Products product4;
        private Products product5;
        private Products product6;

       // Creates the default products.    
        public Methods()
        {
            product1 = new Products { ProductName = "Chicken Joy", ProductPrice = 100 };
            product2 = new Products { ProductName = "Burger Steak", ProductPrice = 150 };
            product3 = new Products { ProductName = "Jolly Spaghetti", ProductPrice = 120 };
            product4 = new Products { ProductName = "Palabok Fiesta", ProductPrice = 130 };
            product5 = null;
            product6 = null;
        }
        // LOGIN METHODS
        // Starts the login process.
        public void Login()
        {
            Accounts manager = new AuthorizeAccounts("admin", "123");
            Accounts cashier = new AuthorizeAccounts("cashier", "123");
            while (true)
            {
                Console.Clear();
                Console.SetCursorPosition(0, GetLoginTop());
                WriteCentered("========================================");
                WriteCentered("POS SYSTEM LOGIN");
                WriteCentered("========================================");
                string username = ReadCenteredInput("USERNAME", false);
                string password = ReadCenteredInput("PASSWORD", true);
                WriteCentered("----------------------------------------");

                if (username == manager.Username && password == manager.Password)
                {
                    OpenDashboard("Manager");
                }
                else if (username == cashier.Username && password == cashier.Password)
                {
                    OpenDashboard("Cashier");
                }
                else
                {
                    PrintCenteredError("[ ERROR ] Invalid Login");
                    Console.ReadKey();
                }
            }
        }

        // Opens the correct role dashboard.
        private void OpenDashboard(string role)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            WriteCentered("[ INFO ] Login Successful: " + role);
            Console.ResetColor();
            Console.ReadKey();

            if (role == "Manager")
            {
                new ProductManagement(this).ShowDashboard();
            }
            else
            {
                new POS(this).ShowDashboard();
            }
        }

        // DASHBOARD METHODS

        // Handles manager choices.
        public bool ManagerDashboardChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    CreateProduct();
                    break;
                case 2:
                    ReadProducts();
                    break;
                case 3:
                    UpdateProduct();
                    break;
                case 4:
                    DeleteProduct();
                    break;
                case 5:
                    return true;
                default:
                    PrintError("\n  [ ERROR ] Invalid Choice");
                    Console.ReadKey();
                    break;
            }
            return false;
        }
        // Handles cashier choices.
        public bool CashierDashboardChoice(int choice)
        {
            switch (choice)
            {
                case 1:
                    SellProduct();
                    break;
                case 2:
                    return true;
                default:
                    PrintError("\n  [ ERROR ] Invalid Choice");
                    Console.ReadKey();
                    break;
            }
            return false;
        }
        // CRUD METHODS

        // C: Creates a product.
        private void CreateProduct()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("             CREATE PRODUCT");
            Console.WriteLine("========================================");

            if (IsProductFull())
            {
                PrintError("  [ ERROR ] Product slots are full.");
                Console.ReadKey();
                return;
            }
            string productName = ReadProductName();
            Console.Write("  Product Price: ");
            int productPrice = ReadPositiveNumber("  Product Price: ");
            Products newProduct = new Products { ProductName = productName, ProductPrice = productPrice };
            SaveProduct(newProduct);

            PrintSuccess("\n  [ INFO ] Product Created Successfully!");
            Console.ReadKey();
        }

        // R: Views all products.
        private void ReadProducts()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("              VIEW PRODUCTS");
            Console.WriteLine("========================================");
            DisplayProducts();
            Console.WriteLine("========================================");
            Console.WriteLine("\n  Press any key to continue...");
            Console.ReadKey();
        }
        // U: Edits a product.
        private void UpdateProduct()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("              EDIT PRODUCT");
            Console.WriteLine("========================================");
            DisplayProducts();
            Console.WriteLine("========================================");
            Console.Write("  Select Product: ");

            int select = ReadChoice();
            Products selectedProduct = GetProduct(select);

            if (selectedProduct == null)
            {
                PrintError("  [ ERROR ] Invalid product selection.");
                Console.ReadKey();
                return;
            }
            selectedProduct.ProductName = ReadProductName();
            Console.Write("  New Product Price: ");
            selectedProduct.ProductPrice = ReadPositiveNumber("  New Product Price: ");

            PrintSuccess("\n  [ INFO ] Product Updated Successfully!");
            Console.ReadKey();
        }
        // D: Deletes a product.
       private void DeleteProduct()
        {
            Console.Clear();
            Console.WriteLine("============================================");
            Console.WriteLine("             DELETE PRODUCT");
            Console.WriteLine("============================================");
            DisplayProducts();
            Console.WriteLine("============================================");
            Console.Write("  Select Product: ");

            int select = ReadChoice();

            if (GetProduct(select) == null)
            {
                PrintError("  [ ERROR ] Invalid product selection.");
                Console.ReadKey();
                return;
            }

            RemoveProduct(select);
            PrintSuccess("\n  [ INFO ] Product Deleted Successfully!");
            Console.ReadKey();
        }

        // Prints all product slots.
        private void DisplayProducts()
        {
            Console.WriteLine(String.Format("  {0,-5} | {1,-18} | {2,10}", "ID", "PRODUCT NAME", "PRICE"));
            Console.WriteLine("------------------------------------------");
            DisplayProduct("[1]", product1);
            DisplayProduct("[2]", product2);
            DisplayProduct("[3]", product3);
            DisplayProduct("[4]", product4);
            DisplayProduct("[5]", product5);
            DisplayProduct("[6]", product6);
        }

        // Prints one existing product.
        private void DisplayProduct(string id, Products product)
        {
            if (product != null)
            {
                Console.WriteLine(String.Format("  {0,-5} | {1,-18} | Php {2,6}", id, product.ProductName, product.ProductPrice));
            }
        }

        // Saves a product in an empty slot.
        private void SaveProduct(Products product)
        {
            if (product1 == null)
            {
                product1 = product;
            }
            else if (product2 == null)
            {
                product2 = product;
            }
            else if (product3 == null)
            {
                product3 = product;
            }
            else if (product4 == null)
            {
                product4 = product;
            }
            else if (product5 == null)
            {
                product5 = product;
            }
            else
            {
                product6 = product;
            }
        }

        // Checks for an empty slot.
        private bool IsProductFull()
        {
            return product1 != null && product2 != null && product3 != null && product4 != null && product5 != null && product6 != null;
        }

        // Gets a product by ID.
        private Products GetProduct(int select)
        {
            switch (select)
            {
                case 1:
                    return product1;
                case 2:
                    return product2;
                case 3:
                    return product3;
                case 4:
                    return product4;
                case 5:
                    return product5;
                case 6:
                    return product6;
                default:
                    return null;
            }
        }

        // Removes a product by ID.
        private void RemoveProduct(int select)
        {
            switch (select)
            {
                case 1:
                    product1 = null;
                    break;
                case 2:
                    product2 = null;
                    break;
                case 3:
                    product3 = null;
                    break;
                case 4:
                    product4 = null;
                    break;
                case 5:
                    product5 = null;
                    break;
                case 6:
                    product6 = null;
                    break;
            }
        }

        // CASHIER METHODS

        // Completes one cashier sale.
        private void SellProduct()
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("                 SELL");
            Console.WriteLine("========================================");
            DisplayProducts();
            Console.WriteLine("========================================");
            Console.Write("  Select Product: ");

            int select = ReadChoice();
            Products selectedProduct = GetProduct(select);

            if (selectedProduct == null)
            {
                PrintError("  [ ERROR ] Invalid product selection.");
                Console.ReadKey();
                return;
            }

            Console.Write("  Enter Quantity: ");
            int quantity = ReadPositiveNumber("  Enter Quantity: ");
            int total = selectedProduct.ProductPrice * quantity;

            Console.WriteLine(String.Format("  Total Amount: Php {0}", total));
            Console.Write("  Enter Payment: ");
            int payment = ReadPayment(total);
            PrintReceipt(selectedProduct, quantity, total, payment);

            Console.WriteLine("\n  Press any key to continue...");
            Console.ReadKey();
        }

        // Prints the sale receipt.
        private void PrintReceipt(Products product, int quantity, int total, int payment)
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("                 RECEIPT");
            Console.WriteLine("========================================");
            Console.WriteLine(String.Format("  Product : {0}", product.ProductName));
            Console.WriteLine(String.Format("  Price   : Php {0}", product.ProductPrice));
            Console.WriteLine(String.Format("  Quantity: {0}", quantity));
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(String.Format("  Total   : Php {0}", total));
            Console.WriteLine(String.Format("  Payment : Php {0}", payment));
            Console.WriteLine(String.Format("  Change  : Php {0}", payment - total));
            Console.WriteLine("========================================");
            Console.WriteLine("  Thank you for your purchase!");
        }

        // INPUT METHODS

        // Reads a menu with arrow keys.
        public int ReadCursorChoice(int optionCount)
        {
            int firstOptionRow = Console.CursorTop - optionCount - 1;
            int selected = 0;
            ConsoleKey key;

            Console.CursorVisible = false;

            while (true)
            {
                DrawCursor(firstOptionRow, optionCount, selected);
                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow && selected > 0)
                {
                    selected--;
                }
                else if (key == ConsoleKey.DownArrow && selected < optionCount - 1)
                {
                    selected++;
                }
                else if (key == ConsoleKey.Enter)
                {
                    Console.CursorVisible = true;
                    return selected + 1;
                }
            }
        }

        // Draws the arrow cursor.
        private void DrawCursor(int firstOptionRow, int optionCount, int selected)
        {
            int option;

            for (option = 0; option < optionCount; option++)
            {
                Console.SetCursorPosition(0, firstOptionRow + option);
                Console.Write(option == selected ? ">" : " ");
            }
        }

        // Centers the login form vertically.
        private int GetLoginTop()
        {
            return Math.Max(0, (Console.WindowHeight - 6) / 2);
        }

        // Writes centered text.
        private void WriteCentered(string text)
        {
            int left = Math.Max(0, (Console.WindowWidth - text.Length) / 2);
            Console.SetCursorPosition(left, Console.CursorTop);
            Console.WriteLine(text);
        }

        // Reads input from a centered, fixed-width field.
        private string ReadCenteredInput(string label, bool hideInput)
        {
            const int inputWidth = 20;
            string field = "" + new string(' ', inputWidth) + "";
            string row = label + ": " + field;
            int rowTop = Console.CursorTop;
            int rowLeft = Math.Max(0, (Console.WindowWidth - row.Length) / 2);
            int inputLeft = rowLeft + label.Length + 3;
            StringBuilder input = new StringBuilder();

            Console.SetCursorPosition(rowLeft, rowTop);
            Console.WriteLine(row);
            Console.SetCursorPosition(inputLeft, rowTop);

            ConsoleKeyInfo key;
            while ((key = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            {
                if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input.Length--;
                    Console.SetCursorPosition(inputLeft + input.Length, rowTop);
                    Console.Write(' ');
                    Console.SetCursorPosition(inputLeft + input.Length, rowTop);
                }
                else if (!char.IsControl(key.KeyChar) && input.Length < inputWidth)
                {
                    input.Append(key.KeyChar);
                    Console.Write(hideInput ? '*' : key.KeyChar);
                }
            }

            Console.SetCursorPosition(0, rowTop + 1);
            return input.ToString();
        }

        // Prints a centered error.
        private void PrintCenteredError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteCentered(message);
            Console.ResetColor();
        }

        // Reads a required product name.
        private string ReadProductName()
        {
            Console.Write("  Product Name: ");
            string productName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(productName))
            {
                PrintError("  [ ERROR ] Product name cannot be empty.");
                Console.Write("  Product Name: ");
                productName = Console.ReadLine();
            }

            return productName;
        }

        // Reads a number input.
        private int ReadNumber(string prompt)
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                PrintError("  [ ERROR ] Please enter a valid number.");
                Console.Write(prompt);
            }

            return number;
        }

        // Reads a menu choice.
        public int ReadChoice()
        {
            return ReadNumber("  Enter Choice: ");
        }

        // Reads a positive number.
        private int ReadPositiveNumber(string prompt)
        {
            int number = ReadNumber(prompt);
            while (number <= 0)
            {
                PrintError("  [ ERROR ] Value must be greater than zero.");
                Console.Write(prompt);
                number = ReadNumber(prompt);
            }

            return number;
        }

        // Reads enough payment.
        private int ReadPayment(int total)
        {
            int payment = ReadPositiveNumber("  Enter Payment: ");
            while (payment < total)
            {
                PrintError("  [ ERROR ] Payment is not enough.");
                Console.Write("  Enter Payment: ");
                payment = ReadPositiveNumber("  Enter Payment: ");
            }

            return payment;
        }

        // MESSAGE METHODS

        // Prints a success message.
        public void PrintSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        // Prints an error message.
        public void PrintError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
