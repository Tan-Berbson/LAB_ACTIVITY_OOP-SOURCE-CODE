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
        public string Name { get; set; }
        public int Price { get; set; }

        //constructor
        public ProductInfo(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
