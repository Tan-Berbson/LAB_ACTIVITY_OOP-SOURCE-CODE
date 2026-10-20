using System;

namespace Tan_OOPLab3.PRODUCT_MANAGEMENT
{
    public class POS : Dashboard
    {
        // Creates the cashier dashboard.
        public POS(Methods systemMethods) : base(systemMethods)
        {
        }

        // Displays the cashier dashboard.
        public override void ShowDashboard()
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
                Console.Write("  Enter Choice: ");

                int choice = methods.ReadChoice();
                cashierLoggedIn = !methods.CashierDashboardChoice(choice);
            }
        }
    }
}
