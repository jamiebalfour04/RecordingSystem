using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Recording_System
{
    public partial class StartupSelector : Form
    {
        static bool splashShown = false;
        public StartupSelector()
        {
            InitializeComponent();
            if (!splashShown)
            {
                splashShown = true;
                this.Visible = false;
                Thread t = new Thread(new ThreadStart(OpenSplashScreen));
                t.Start();
                Thread.Sleep(1400);

                t.Abort();
                this.Visible = true;
            }
            
            this.BringToFront();
            this.Focus();
           

        }

        private void OpenSplashScreen()
        {
            Application.Run(new SplashScreen());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new RecordSomething().Visible = true;
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!Program.LOGGED_IN)
            {
                new PasswordForm().Visible = true;
                this.Visible = false;
            }
            else
            {
                new SelectMessage().Visible = true;
                this.Visible = false;
            }
            
        }

        private void StartupSelector_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Resources.applicationName;
            this.BringToFront();
            this.Focus();

        }


        private void StartupSelector_Closing(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
