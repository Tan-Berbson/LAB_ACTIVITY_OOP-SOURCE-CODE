using System;

namespace Tan_OOPLab3.PRODUCT_MANAGEMENT
{
    internal class ProductManagement : Dashboard
    {
        // Creates the manager dashboard.
        public ProductManagement(Methods systemMethods) : base(systemMethods)
        {
        }

        // Displays the manager dashboard.
        public override void ShowDashboard()
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
                Console.WriteLine("  [5] Logout");
                Console.WriteLine("----------------------------------------");
                Console.Write("  Enter Choice: ");

                int choice = methods.ReadChoice();
                managerLoggedIn = !methods.ManagerDashboardChoice(choice);
            }
        }
    }
}
