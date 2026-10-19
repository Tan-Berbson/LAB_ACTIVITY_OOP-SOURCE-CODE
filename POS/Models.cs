using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tan_OOPLab3.POS
{
    public class Models
    {
        public class Accounts
        {
            public string Username {  get; set; }
            public string Password { get; set; }
        }
        public class Products
        {
            public string ProductName { get; set; }
            public int ProductPrice { get; set; }

            public int ProductQuantity { get; set; }

        }
    }
}
