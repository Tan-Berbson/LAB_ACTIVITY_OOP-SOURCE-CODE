using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tan_OOPLab3.Models
{
    //class
    internal class ProductInfo
    {
        private string _name;
        private int _price;

        // Name property
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Enter Product Name");
                }
                else
                {
                    _name = value;
                }
            }
        }

        // Price property
        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Enter a valid Product Price");
                }
                else
                {
                    _price = value;
                }
            }
        }

        // Constructor
        public ProductInfo(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
