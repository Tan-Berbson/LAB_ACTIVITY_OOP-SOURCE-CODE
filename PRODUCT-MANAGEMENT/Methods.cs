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

        }
        // Update Products
        public void Update()
        {

        }
        // Read Products
        public void Read()
        {     
            Console.WriteLine($"Product 1: {product1.ProductName}, Price: {product1.ProductPrice}");
            Console.WriteLine($"Product 2: {product2.ProductName}, Price: {product2.ProductPrice}");
            Console.WriteLine($"Product 3: {product3.ProductName}, Price: {product3.ProductPrice}");
            Console.WriteLine($"Product 4: {product4.ProductName}, Price: {product4.ProductPrice}");
        }
        // Delete Products
        public void Delete()
        {
        }
        
       

    }
}
