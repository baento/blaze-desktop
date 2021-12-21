using Core;

namespace Gui
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            API.Initialize();
            Application.Run(new MainForm());
        }
    }
}