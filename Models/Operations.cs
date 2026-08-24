using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Tan_OOPLab3.Models
{
    internal class Operations
    {
        private string name;
        private double price;

        public string Name
        {
            get { return name; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("ProductName cannot be empty!");
                }
                else
                {
                    name = value;
                }
            }
        }
        public double Price
        {
            get { return price; }
            set
            {
                if(value <= 0)
                {
                    Console.WriteLine("Product Price must not be Negative");
                }
                else
                {
                    price = value;
                }
            }
        }
        public Operations(string name , double price)
        {
            Name = name;
            Price = price;
        }
       
       
    }
}
