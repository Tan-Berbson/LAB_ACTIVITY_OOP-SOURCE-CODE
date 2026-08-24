using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tan_OOPLab3.Models
{
    internal class Pos :  Operations
    {
        private Pos product1 = new Pos("coke", 100);
        public Pos(string name, double price) : base(name, price)
        {

        }

        public void Transaction()
        {
            Console.WriteLine("==transaction==");
            Console.WriteLine("[1]" + product1.Price.ToString("0.00") + product1.Name  );
            Console.WriteLine(" ");

            int choice  = Convert.ToInt32(Console.ReadLine());

            Pos selectedproduct = null;
            if(choice == 1)
            {
                selectedproduct = product1;
            }

            Console.WriteLine("Enter Quantity");
            double quantity = Convert.ToDouble(Console.ReadLine());

            double total = selectedproduct.Price * quantity;
        }

        //Dashboard 
        public void Dashboard()
        {
            Console.WriteLine("=== POS DASHBOARD ===");
            Console.WriteLine("[1] Manage Products");
            Console.WriteLine("[2] View All Products");
            Console.WriteLine("[3] Cashier Operations");
            Console.WriteLine("[4] Exit");
            Console.WriteLine("======================");

            Console.WriteLine("Select an Options? ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                      break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid Choice");
                    Console.ReadKey();
                    break;
            }
        }


    }
}
