using System;
using System.IO;
using System.Windows.Forms;

namespace RecordingSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Directory.CreateDirectory("ProgramOutput/");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartupSelector());
        }


        public static readonly string CIPHER = "knox2024";
        //public static readonly string PROGRAM_PATH = @"S:\Staff Work\Responsibility of All\Staff Reporting System\Program Output\";
        public static readonly string PROGRAM_PATH = "ProgramOutput/";
        public static bool LOGGED_IN = false;
    }
}
