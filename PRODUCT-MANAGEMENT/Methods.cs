using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tan_OOPLab3.PRODUCT_MANAGEMENT;
using static Tan_OOPLab3.POS.Models;

namespace Tan_OOPLab3.PRODUCT_MANAGEMENT
{
    public class Methods
    {
        // objects of Products class
        private Products product1;
        private Products product2;
        private Products product3;
        private Products product4;
        private Products AddProduct1;
        private Products AddProduct2;

        // static data members of Products class
        public Methods()
        {
            product1 = new Products{ ProductName = "Chicken Joy", ProductPrice = 100 };
            product2 = new Products{ ProductName = "Burger Steak", ProductPrice = 150 };
            product3 = new Products{ ProductName = "Jolly Spaghetti", ProductPrice = 120 };
            product4 = new Products{ ProductName = "Palabok Fiesta", ProductPrice = 130 };

            AddProduct1 = null;
            AddProduct2 = null;

        }
        // Create Products
        public void Create()
        {
            Console.Clear();
            Products products1 = new Products();
            products1.ProductName = "Chicken joy";
            products1.ProductPrice = 199;
            Products products2 = new Products();
            products2.ProductName = "Hamburger";
            products2.ProductPrice = 100;
            Products products3 = new Products();
            products3.ProductName = "Hotdogs";
            products3.ProductPrice = 100;
            Products products4 = new Products();
            products4.ProductName = "Footlong";
            products4.ProductPrice = 100;

            Console.WriteLine("========================================");
            Console.WriteLine("               EDIT PRODUCT");
            Console.WriteLine("========================================");
            // Added the [1], [2] IDs to the display table
            Console.WriteLine(String.Format("  {0,-5} | {1,-15} | {2,10}", "ID", "PRODUCT NAME", "PRICE"));
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(String.Format("  {0,-5} | {1,-15} | Php {2,6}", "[1]", products1.ProductName, products1.ProductPrice));
            Console.WriteLine(String.Format("  {0,-5} | {1,-15} | Php {2,6}", "[2]", products2.ProductName, products2.ProductPrice));
            Console.WriteLine(String.Format("  {0,-5} | {1,-15} | Php {2,6}", "[3]", products3.ProductName, products3.ProductPrice));
            Console.WriteLine(String.Format("  {0,-5} | {1,-15} | Php {2,6}", "[4]", products4.ProductName, products4.ProductPrice));
            Console.WriteLine("========================================");

            Console.Write("  Select which product to edit: ");

            // Validate the Choice input using TryParse
            int select = 
            
            Console.WriteLine("----------------------------------------");

            string newName;
           
            int newPrice;

            switch (select)
            {
                case 1:
                    // Validate String
                    Console.Write("  New Product Name: ");
                    newName = Console.ReadLine();
                    newName = ReadProductName();
                    products1.ProductName = newName;

                    Console.Write("  New Product Quantity: ");
                    



                    Console.WriteLine("\n  [ INFO ] Product Updated Successfully!");
                    Console.ReadKey();
                   
                    break;

                case 2:
                    Console.Write("  New Product Name: ");
                    newName = Console.ReadLine();
                    newName = ReadProductName();
                    products2.ProductName = newName;


                    Console.Write("  New Product Price: ");
                    while (!int.TryParse(Console.ReadLine(), out newPrice))
                    {
                        Console.WriteLine("  [ ERROR ] Invalid price. Must be a number.");
                        Console.Write("  New Product Price: ");
                    }
                    products2.ProductPrice = newPrice;

                    Console.WriteLine("\n  [ INFO ] Product Updated Successfully!");
                    Console.ReadKey();
                   
                    break;

                case 3:
                    Console.Write("  New Product Name: ");
                    newName = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(newName))
                    {
                        Console.WriteLine("  [ ERROR ] Name cannot be empty.");
                        Console.Write("  New Product Name: ");
                        newName = Console.ReadLine();
                    }
                    products3.ProductName = newName;


                    Console.Write("  New Product Price: ");
                    while (!int.TryParse(Console.ReadLine(), out newPrice))
                    {
                        Console.WriteLine("  [ ERROR ] Invalid price. Must be a number.");
                        Console.Write("  New Product Price: ");
                    }
                    products3.ProductPrice = newPrice;

                    Console.WriteLine("\n  [ INFO ] Product Updated Successfully!");
                    Console.ReadKey();
                 
                    break;

                case 4:
                    Console.Write("  New Product Name: ");
                    newName = Console.ReadLine();
                    newName = ReadProductName();
                    products4.ProductName = newName;



                    Console.Write("  New Product Price: ");
                    int newPrice4 = ReadProductPrice();
                    products4.ProductPrice = newPrice4;

                    Console.WriteLine("\n  [ INFO ] Product Updated Successfully!");
                    Console.ReadKey();
                   
                    break;

                default:
                    Console.WriteLine("\n  [ ERROR ] Invalid Select");
                    Console.ReadKey();
                   
                    break;
            }
        }
        // Update Products
        public void Update()
        {

        }
        // Read Products
        public void Read()
        {
            Console.Clear();
            Products products1 = new Products();
            products1.ProductName = "Chicken joy";
            products1.ProductPrice = 199;
            Products products2 = new Products();
            products2.ProductName = "Hamburger";
            products2.ProductPrice = 100;
            Products products3 = new Products();
            products3.ProductName = "Hotdogs";
            products3.ProductPrice = 100;
            Products products4 = new Products();
            products4.ProductName = "Footlong";
            products4.ProductPrice = 100;

            Console.WriteLine("========================================");
            Console.WriteLine("               PRODUCT LIST");
            Console.WriteLine("========================================");
            Console.WriteLine(String.Format("  {0,-15} | {1,10}", "PRODUCT NAME", "PRICE"));
            Console.WriteLine("----------------------------------------");

            Console.WriteLine(String.Format("  {0,-15} | Php {1,6}", products1.ProductName, products1.ProductPrice));
            Console.WriteLine(String.Format("  {0,-15} | Php {1,6}", products2.ProductName, products2.ProductPrice));
            Console.WriteLine(String.Format("  {0,-15} | Php {1,6}", products3.ProductName, products3.ProductPrice));
            Console.WriteLine(String.Format("  {0,-15} | Php {1,6}", products4.ProductName, products4.ProductPrice));
            Console.WriteLine("========================================");

            Console.WriteLine("\n  Press any key to continue...");
            Console.ReadKey();
            
        }
        // Delete Products
        public void Delete()
        {
        }
        public string ReadProductName()
        {
            Console.Write("  New Product Name: ");
            string newName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(newName))
            {
                Console.WriteLine("  [ ERROR ] Name cannot be empty.");
                Console.Write("  New Product Name: ");
                newName = Console.ReadLine();
            }

            return newName;
        }
        public int ReadProductPrice()
        {
            int newPrice;

            Console.Write("  New Product Price: ");

            while (!int.TryParse(Console.ReadLine(), out newPrice))
            {
                Console.WriteLine(
                    "  [ ERROR ] Invalid price. Must be a number.");

                Console.Write("  New Product Price: ");
            }

            return newPrice;
        }



    }
}
