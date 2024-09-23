using System;
using System.Windows.Forms;

namespace Recording_System_3._5
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (usernameInput.Text == Properties.Resources.username && passwordInput.Text == Properties.Resources.password)
            {
                new SelectMessage().Visible = true;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Incorrect login details. Please try again.", "Please try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {
        }
    }
}
