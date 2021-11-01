using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class LoginForm : Form
    {
        private State state = State.getState();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void navigateToApp()
        {
            this.Hide();
            (new Container()).Show(); // NOTE: check if there is a way to show existing container
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            // CHECK CREDENTIALS WITH DATABASE HERE

            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;

            state.Username = username;
            state.AccessLevel = Constants.ADMIN;

            navigateToApp();
        }
    }
}
