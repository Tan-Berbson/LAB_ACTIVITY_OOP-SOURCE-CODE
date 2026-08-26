using System;

namespace Tan_OOPLab3.Models
{
    internal class ProductInfo
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public ProductInfo(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
