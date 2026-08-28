using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tan_OOPLab3.Models
{
    internal class ProductManager
    {
        // Products from product info class
        private ProductInfo product1;
        private ProductInfo product2;
        private ProductInfo product3;
        private ProductInfo product4;
        private ProductInfo product5;

        // Sale information
        // variable rana ang soldproduct
        private ProductInfo soldProduct;
        private int soldQuantity;
        private int total;

         // Constructor to initialize products from ProductInfo class
        public ProductManager()
        {
            product1 = new ProductInfo("Hamburger", 100);
            product2 = new ProductInfo("Fries", 50);
            product3 = new ProductInfo("Chicken", 120);
            product4 = new ProductInfo("Coke", 30);
            product5 = new ProductInfo("Ice Cream", 40);
        }

        public void ViewAllProduct()
        {
            Console.WriteLine("=== PRODUCTS ===");

            Console.WriteLine("1. " + product1.Name + " - " + product1.Price);
            Console.WriteLine("2. " + product2.Name + " - " + product2.Price);
            Console.WriteLine("3. " + product3.Name + " - " + product3.Price);
            Console.WriteLine("4. " + product4.Name + " - " + product4.Price);
            Console.WriteLine("5. " + product5.Name + " - " + product5.Price);
        }

        public void Dashboard()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();

                Console.WriteLine("========== DASHBOARD ==========");
                Console.WriteLine("1. View Products");
                Console.WriteLine("2. Manage Product");
                Console.WriteLine("3. Sell Product");
                Console.WriteLine("4. Exit");
                Console.WriteLine("===============================");

                Console.Write("Select: ");

                // Try parse to validate user input for menu selection
                int select;
                while (!int.TryParse(Console.ReadLine(), out select))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.Write("Select: ");
                }

                Console.Clear();

                switch (select)
                {
                    case 1:
                        ViewAllProduct();
                        break;
                    case 2:
                        ManageProduct();
                        break;
                    case 3:
                        StartSell();
                        break;
                    case 4:
                        running = false;
                        Console.WriteLine("Thank you!");
                        break;
                    default:
                        Console.WriteLine("Invalid selection.");
                        break;
                }

                if (running)
                {
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        public void ManageProduct()
        {
            ViewAllProduct();

            Console.WriteLine();
            Console.Write("Select which to edit: ");

            int select;
            // Validate user selection
            while (!int.TryParse(Console.ReadLine(), out select))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.Write("Select which to edit: ");
            }

            switch (select)
            {
                case 1:
                    EditProduct(product1);
                    break;
                case 2:
                    EditProduct(product2);
                    break;
                case 3:
                    EditProduct(product3);
                    break;
                case 4:
                    EditProduct(product4);
                    break;
                case 5:
                    EditProduct(product5);
                    break;
                default:
                    Console.WriteLine("Invalid product.");
                    break;
            }
        }

        private void EditProduct(ProductInfo product)
        {
            Console.Write("New Product Name: ");
            string newName = Console.ReadLine();

            // Try parse to validate user input for product name
            while (string.IsNullOrWhiteSpace(newName))
            {
                Console.WriteLine("Product name cannot be empty. Please enter a valid name.");
                Console.Write("New Product Name: ");
                newName = Console.ReadLine();
            }

            // Assign the validated name
            product.Name = newName;

            // Prompt for the price BEFORE the validation loop starts
            Console.Write("New Product Price: ");

            // Try parse to validate user input for price
            int newPrice;
            while (!int.TryParse(Console.ReadLine(), out newPrice))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("New Product Price: ");
            }

            // Assign and Validate Product Price
            product.Price = newPrice;

            Console.WriteLine("Product updated successfully!");
        }
        public void StartSell()
        {
            ViewAllProduct();

            Console.WriteLine();
            Console.Write("Which product to sell: ");

            // Try parse to validate user input for product selection
            int select;
            while (!int.TryParse(Console.ReadLine(), out select))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                Console.Write("Which product to sell: ");
            }

            switch (select)
            {
                case 1:
                    soldProduct = product1;
                    break;
                case 2:
                    soldProduct = product2;
                    break;
                case 3:
                    soldProduct = product3;
                    break;
                case 4:
                    soldProduct = product4;
                    break;
                case 5:
                    soldProduct = product5;
                    break;
                default:
                    Console.WriteLine("Invalid product.");
                    return;
            }

            Console.Write("Quantity: ");

            // Try parse to validate user input for quantity
            while (!int.TryParse(Console.ReadLine(), out soldQuantity))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("Quantity: ");
            }

            total = soldProduct.Price * soldQuantity;

            Console.WriteLine();
            Console.WriteLine("Sale successful!");

            Console.WriteLine();
            Receipt();
        }

        public void Receipt()
        {
            if (soldProduct == null)
            {
                Console.WriteLine("No sale available.");
                return;
            }

            Console.WriteLine("========== RECEIPT ==========");
            Console.WriteLine("Product: " + soldProduct.Name);
            Console.WriteLine("Price: " + soldProduct.Price);
            Console.WriteLine("Quantity: " + soldQuantity);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Total: " + total);
            Console.WriteLine("=============================");
        }
    }
}