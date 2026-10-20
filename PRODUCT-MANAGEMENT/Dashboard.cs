namespace Tan_OOPLab3.PRODUCT_MANAGEMENT
{
    // Base class for dashboards.
    public abstract class Dashboard
    {
        protected Methods methods;

        // Shares the system methods.
        protected Dashboard(Methods systemMethods)
        {
            methods = systemMethods;
        }

        // Displays a role dashboard.
        public abstract void ShowDashboard();
    }
}
