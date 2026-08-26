using System;

namespace Tan_OOPLab3.Models
{
    internal class ProductManager
    {
        // Products
        private ProductInfo product1;
        private ProductInfo product2;
        private ProductInfo product3;
        private ProductInfo product4;
        private ProductInfo product5;

        // Sale information
        private ProductInfo soldProduct;
        private int soldQuantity;
        private int total;

        public ProductManager()
        {
            product1 = new ProductInfo("Hamburger", 100);
            product2 = new ProductInfo("Fries", 50);
            product3 = new ProductInfo("Chicken", 120);
            product4 = new ProductInfo("Coke", 30);
            product5 = new ProductInfo("Ice Cream", 40);
        }

        public void View()
        {
            Console.WriteLine("=== PRODUCTS ===");

            Console.WriteLine("1. " + product1.Name + " - ₱" + product1.Price);
            Console.WriteLine("2. " + product2.Name + " - ₱" + product2.Price);
            Console.WriteLine("3. " + product3.Name + " - ₱" + product3.Price);
            Console.WriteLine("4. " + product4.Name + " - ₱" + product4.Price);
            Console.WriteLine("5. " + product5.Name + " - ₱" + product5.Price);
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

                // Added TryParse for Dashboard selection
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
                        View();
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
            View();

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

            // Validate the string input
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

            // Validate the integer input
            int newPrice;
            while (!int.TryParse(Console.ReadLine(), out newPrice))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                Console.Write("New Product Price: ");
            }

         
            product.Price = newPrice;

            Console.WriteLine("Product updated successfully!");
        }
        public void StartSell()
        {
            View();

            Console.WriteLine();
            Console.Write("Which product to sell: ");

            // Added TryParse for Product Selection
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

            // Added TryParse for Quantity
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
            Console.WriteLine("Price: ₱" + soldProduct.Price);
            Console.WriteLine("Quantity: " + soldQuantity);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Total: ₱" + total);
            Console.WriteLine("=============================");
        }
    }
}