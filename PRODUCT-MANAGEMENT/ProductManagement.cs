using System;

namespace Tan_OOPLab3.PRODUCT_MANAGEMENT
{
    internal class ProductManagement
    {
        //
        private readonly Methods methods;

        // Creates the manager dashboard.
        public ProductManagement(Methods systemMethods)
        {
            methods = systemMethods;
        }

        // Displays the manager dashboard.
        public void ShowDashboard()
        {
            bool managerLoggedIn = true;

            while (managerLoggedIn)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("          PRODUCT MANAGEMENT");
                Console.WriteLine("========================================");
                Console.WriteLine("  [1] Create Product");
                Console.WriteLine("  [2] View Products");
                Console.WriteLine("  [3] Edit Product");
                Console.WriteLine("  [4] Delete Product");
                Console.WriteLine("  [5] Sell Product");
                Console.WriteLine("  [6] Logout");
                Console.WriteLine("----------------------------------------");

                int choice = methods.ReadCursorChoice(6);
                managerLoggedIn = !methods.ManagerDashboardChoice(choice);
            }
        }
    }
}
