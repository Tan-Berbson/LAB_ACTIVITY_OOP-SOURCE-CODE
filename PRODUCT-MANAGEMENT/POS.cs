using System;

namespace Tan_OOPLab3.PRODUCT_MANAGEMENT
{
    public class POS
    {
        private readonly Methods methods;

        // Creates the cashier dashboard.
        public POS(Methods systemMethods)
        {
            methods = systemMethods;
        }



        // Displays the cashier dashboard.
        public void ShowDashboard()
        {
            bool cashierLoggedIn = true;

            while (cashierLoggedIn)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("            CASHIER DASHBOARD");
                Console.WriteLine("========================================");
                Console.WriteLine("  [1] Sell");
                Console.WriteLine("  [2] Logout");
                Console.WriteLine("----------------------------------------");

                int choice = methods.ReadCursorChoice(2);
                cashierLoggedIn = !methods.CashierDashboardChoice(choice);
            }
        }
    }
}
