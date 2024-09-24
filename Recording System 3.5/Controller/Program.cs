using System;
using System.Windows.Forms;

namespace Recording_System_3._5
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartupSelector());
        }


        public static readonly string CIPHER = "knox2024";
        //public static readonly string PROGRAM_PATH = @"S:\Staff Work\Responsibility of All\Staff Reporting System\Program Output\";
        public static readonly string PROGRAM_PATH = Properties.Resources.mainPath;
        public static bool LOGGED_IN = false;
    }
}
