using UI.Login;
namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var newEmployee = new Employee("Luuk", "van der Berg", "Luuk.vanderBerg@gmail.com", null, ERole.Employee, null, "66eb0b6cea00799cc5ed6eeb", EDepartment.Finance, null);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new EmployeeUI.EmployeeUI());
        }
    }
}