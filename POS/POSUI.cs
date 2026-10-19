using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Tan_OOPLab3.POS
{
    public  class POSUI : Models
    {
        public void Login()
        {
            Accounts acc = new Accounts();
            Console.Clear();
            Console.WriteLine("Dashboard");
            Console.WriteLine("USERNAME:");
            string username = Console.ReadLine();
            Console.WriteLine("PASSWORD");
            string password = Console.ReadLine();
            if (username == acc.Username && password == acc.Password)
            {
                Console.WriteLine("Login Succesfull");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Invalid Login");
                Console.ReadKey();
                Login();
            }

        }
        public void Dashboard()
        {
            Console.WriteLine("Dashboard");
            Console.WriteLine("[1] view products");
            Console.WriteLine("[2] Manage Products");
            Console.WriteLine("[3] logout");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    ViewProduct();
                    break;
                case 2:
                    ManageProduct();
                    break;
                case 3:
                    Login();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

        public void ViewProduct()
        {
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

            Console.WriteLine("Product List");
            Console.WriteLine(products1.ProductName);
            Console.WriteLine(products1.ProductPrice);
            Console.WriteLine(products2.ProductName);
            Console.WriteLine(products2.ProductPrice);
            Console.WriteLine(products3.ProductName);
            Console.WriteLine(products3.ProductPrice);
            Console.WriteLine(products4.ProductName);
            Console.WriteLine(products4.ProductPrice);
            
        }
        public void ManageProduct()
        {
            Console.WriteLine("Manage Product");
            Console.WriteLine("[1] Edit Product");
            Console.WriteLine("[2] Add Product");
            Console.WriteLine("[3] Back");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    EditProduct();
                    break;
                case 2:
                    AddProduct();
                    break;
                case 3:
                    Dashboard();
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
        public void EditProduct()
        {
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
            ViewProduct();
            Console.WriteLine("select which product to edit");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.WriteLine("Newproduct Name:");
                    products1.ProductName = Console.ReadLine();
                    Console.WriteLine("NewProduct Quantity:");
                    products2.ProductQuantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("NewProduct Price:");
                    products1.ProductPrice = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Newproduct Name:");
                    products1.ProductName = Console.ReadLine();
                    Console.WriteLine("NewProduct Quantity:");
                    products2.ProductQuantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("NewProduct Price:");
                    products1.ProductPrice = Convert.ToInt32(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Newproduct Name:");
                    products1.ProductName = Console.ReadLine();
                    Console.WriteLine("NewProduct Quantity:");
                    products2.ProductQuantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("NewProduct Price:");
                    products1.ProductPrice = Convert.ToInt32(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("Newproduct Name:");
                    products1.ProductName = Console.ReadLine();
                    Console.WriteLine("NewProduct Quantity:");
                    products2.ProductQuantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("NewProduct Price:");
                    products1.ProductPrice = Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Invalid Select");
                    break;
            }
        }
        public void AddProduct()
        {
            ViewProduct();
        }


    }
}
