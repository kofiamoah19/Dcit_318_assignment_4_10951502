using LoginScreenApplication;
using System;
using System.Windows.Forms;

namespace LoginScreenApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            MessageBox.Show($"Username: {username}, Password: {password}");
        }
    }
}











