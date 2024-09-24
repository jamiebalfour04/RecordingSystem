using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Recording_System_3._5
{
    public partial class SplashScreen : Form
    {
        public static SplashScreen s;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            s = this;
            label3.Width = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label3.Width = label3.Width + 7;
        }
    }
}
