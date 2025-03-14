using BookHaven.Data.Models;
using BookHaven.Presentation;

using BookHaven.Presentation.Admin;

using BookHaven.Presentation.Comman;
using BookHaven.Presentation.Staff;


namespace BookHaven
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}