using TicTacToeGameArchitecture.Presenters;
using TicTacToeGameArchitecture.Views;

namespace TicTacToeGameArchitecture
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
            Form1 forma = new Form1();
            Form1Presenter presenter = new Form1Presenter(forma);
            Application.Run(forma);

        }
    }
}