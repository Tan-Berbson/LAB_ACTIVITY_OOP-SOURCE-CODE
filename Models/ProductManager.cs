
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Tan_OOPLab3.Models
{
    internal class ProductManager
    {
        // Product and sales fields
        private ProductFood food1;
        private ProductFood food2;
        private ProductFood food3;
        private ProductFood food4;
        private ProductFood food5;

        private ProductDrinks drink1;
        private ProductDrinks drink2;
        private ProductDrinks drink3;
        private ProductDrinks drink4;
        private ProductDrinks drink5;

        private ProductInfo soldProduct;
        private int soldQuantity;
        private int total;

        // Initialize product data
        public ProductManager()
        {
            food1 = new ProductFood(1, "Hamburger", 100);
            food2 = new ProductFood(2, "Fries", 50);
            food3 = new ProductFood(3, "Chicken", 120);
            food4 = new ProductFood(4, "Pizza", 150);
            food5 = new ProductFood(5, "Ice Cream", 40);

            drink1 = new ProductDrinks(6, "Coke", 30);
            drink2 = new ProductDrinks(7, "Sprite", 30);
            drink3 = new ProductDrinks(8, "Royal", 30);
            drink4 = new ProductDrinks(9, "Iced Tea", 40);
            drink5 = new ProductDrinks(10, "Coffee", 50);
        }

        // Start the login process
        public void StartSystem()
        {
            Console.Clear();

            Console.WriteLine("================================");
            Console.WriteLine("       PRODUCT SYSTEM LOGIN");
            Console.WriteLine("================================");

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            AuthorizeAccounts account = new AuthorizeAccounts();

            string role = account.Login(username, password);

            if (role == "Invalid")
            {
                Console.WriteLine();
                Console.WriteLine("Invalid username or password.");
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                Console.Clear();
                StartSystem();
            }

            Console.WriteLine();
            Console.WriteLine("Login successful!");
            Console.WriteLine("Account: " + role);

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            Dashboard(role);
        }

        // Display the dashboard based on the user's role
        public void Dashboard(string role)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();

                Console.WriteLine("================================");
                Console.WriteLine("           DASHBOARD");
                Console.WriteLine("================================");
                Console.WriteLine("Logged in as: " + role);
                Console.WriteLine();

                if (role == "Admin")
                {
                    Console.WriteLine("1. View Products");
                    Console.WriteLine("2. Manage Products");
                    Console.WriteLine("3. Logout");
                }
                else if (role == "Cashier")
                {
                    Console.WriteLine("1. Sell Product");
                    Console.WriteLine("2. Logout");
                }

                Console.WriteLine("================================");
                Console.Write("Select: ");

                int select;

                while (!int.TryParse(Console.ReadLine(), out select))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.Write("Select: ");
                }

                if (role == "Admin")
                {
                    switch (select)
                    {
                        case 1:
                            Console.Clear();
                            ViewAllProduct();
                            Pause();
                            break;

                        case 2:
                            Console.Clear();
                            ManageProduct();
                            Pause();
                            break;

                        case 3:
                            running = false;
                            Console.WriteLine("Logging out...");
                            StartSystem();
                            break;

                        default:
                            Console.WriteLine("Invalid selection.");
                            Pause();
                            break;
                    }
                }
                else if (role == "Cashier")
                {
                    switch (select)
                    {
                        case 1:
                            Console.Clear();
                            StartSell();
                            Pause();
                            break;

                        case 2:
                            running = false;
                            Console.WriteLine("Logging out...");
                            StartSystem();
                            break;

                        default:
                            Console.WriteLine("Invalid selection.");
                            Pause();
                            break;
                    }
                }
            }
        }
        // Display all available products
        public void ViewAllProduct()
        {
            Console.WriteLine("================================");
            Console.WriteLine("             FOODS");
            Console.WriteLine("================================");

            Console.WriteLine("1. " + food1.Name + " - " + food1.Price);
            Console.WriteLine("2. " + food2.Name + " - " + food2.Price);
            Console.WriteLine("3. " + food3.Name + " - " + food3.Price);
            Console.WriteLine("4. " + food4.Name + " - " + food4.Price);
            Console.WriteLine("5. " + food5.Name + " - " + food5.Price);

            Console.WriteLine();

            Console.WriteLine("================================");
            Console.WriteLine("            DRINKS");
            Console.WriteLine("================================");

            Console.WriteLine("6. " + drink1.Name + " - " + drink1.Price);
            Console.WriteLine("7. " + drink2.Name + " - " + drink2.Price);
            Console.WriteLine("8. " + drink3.Name + " - " + drink3.Price);
            Console.WriteLine("9. " + drink4.Name + " - " + drink4.Price);
            Console.WriteLine("10. " + drink5.Name + " - " + drink5.Price);

            Console.WriteLine("================================");
        }

        // Allow the admin to edit a product
        public void ManageProduct()
        {
            ViewAllProduct();

            Console.WriteLine();
            Console.Write("Select which to edit: ");

            int select;

            while (!int.TryParse(Console.ReadLine(), out select))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.Write("Select which to edit: ");
            }

            switch (select)
            {
                case 1:
                    EditProduct(food1);
                    break;

                case 2:
                    EditProduct(food2);
                    break;

                case 3:
                    EditProduct(food3);
                    break;

                case 4:
                    EditProduct(food4);
                    break;

                case 5:
                    EditProduct(food5);
                    break;

                case 6:
                    EditProduct(drink1);
                    break;

                case 7:
                    EditProduct(drink2);
                    break;

                case 8:
                    EditProduct(drink3);
                    break;

                case 9:
                    EditProduct(drink4);
                    break;

                case 10:
                    EditProduct(drink5);
                    break;

                default:
                    Console.WriteLine("Invalid product.");
                    break;
            }
        }

        // Edit the selected product
        private void EditProduct(ProductInfo product)
        {
            Console.WriteLine();
            Console.WriteLine("Editing: " + product.Name);

            Console.Write("New Product Name: ");
            string newName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(newName))
            {
                Console.WriteLine("Product name cannot be empty.");
                Console.Write("New Product Name: ");
                newName = Console.ReadLine();
            }

            product.Name = newName;

            Console.Write("New Product Price: ");

            int newPrice;

            while (!int.TryParse(Console.ReadLine(), out newPrice) || newPrice <= 0)
            {
                Console.WriteLine("Please enter a valid price.");
                Console.Write("New Product Price: ");
            }

            product.Price = newPrice;

            Console.WriteLine();
            Console.WriteLine("Product updated successfully!");
        }


        // Start the product selling process
        public void StartSell()
        {
            ViewAllProduct();

            Console.WriteLine();
            Console.Write("Which product to sell: ");

            int select;

            while (!int.TryParse(Console.ReadLine(), out select))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.Write("Which product to sell: ");
            }

            switch (select)
            {
                case 1:
                    soldProduct = food1;
                    break;

                case 2:
                    soldProduct = food2;
                    break;

                case 3:
                    soldProduct = food3;
                    break;

                case 4:
                    soldProduct = food4;
                    break;

                case 5:
                    soldProduct = food5;
                    break;

                case 6:
                    soldProduct = drink1;
                    break;

                case 7:
                    soldProduct = drink2;
                    break;

                case 8:
                    soldProduct = drink3;
                    break;

                case 9:
                    soldProduct = drink4;
                    break;

                case 10:
                    soldProduct = drink5;
                    break;

                default:
                    Console.WriteLine("Invalid product.");
                    return;
            }

            Console.Write("Quantity: ");

            // Validate the quantity input
            while (!int.TryParse(Console.ReadLine(), out soldQuantity) || soldQuantity <= 0)
            {
                Console.WriteLine("Invalid quantity. Please enter a valid number.");
                Console.Write("Quantity: ");
            }

            total = soldProduct.Price * soldQuantity;

            Console.WriteLine();
            Console.WriteLine("Sale successful!");

            Console.WriteLine();
            Receipt();
        }

        // Display the sales receipt
        public void Receipt()
        {
            if (soldProduct == null)
            {
                Console.WriteLine("No sale available.");
                return;
            }
            Console.Clear();

            Console.WriteLine("================================");
            Console.WriteLine("             RECEIPT");
            Console.WriteLine("================================");

            Console.WriteLine("Product : " + soldProduct.Name);
            Console.WriteLine("Category: " + soldProduct.Category);
            Console.WriteLine("Price   : " + soldProduct.Price);
            Console.WriteLine("Quantity: " + soldQuantity);

            Console.WriteLine("--------------------------------");

            Console.WriteLine("TOTAL   : " + total);

            Console.WriteLine("================================");
        }
        // Console Readkey Method
        private void Pause()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}

