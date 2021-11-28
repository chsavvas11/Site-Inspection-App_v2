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

            // Create a user for each access level
            DBConnection.getInstanceOfDBConnection().createNewUser(Constants.NEW_USER, "inspector", "password", Constants.INSPECTOR, "John", "Doe");
            DBConnection.getInstanceOfDBConnection().createNewUser(Constants.NEW_USER, "admin", "password", Constants.ADMIN, "Chris", "Noe");
        }

        // Navigates to app
        private void navigateToApp()
        {
            this.Hide();
            (new Container()).Show(); // NOTE: check if there is a way to show existing container
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            // Get username and password from TextBox components
            string username = UsernameTextBox.Text.Trim();
            string password = PasswordTextBox.Text.Trim();

            // Get DataSet with record that matches credentials
            DataSet credentialDataSet = DBConnection
                .getInstanceOfDBConnection()
                .getDataSet(Constants.SELECT_USER_WITH_LOGIN_CREDENTIALS(username, password));

            // Get DataTable from DataSet
            DataTable dataTable = credentialDataSet.Tables[0];
            
            // If a record exists then user credentials are correct
            if (dataTable.Rows.Count > 0)
            {
                // Get access level from record
                string accessLevel = dataTable.Rows[0]["access_level"].ToString();

                // Set state
                state.Username = username;
                // state.AccessLevel = accessLevel;
                state.AccessLevel = Constants.INSPECTOR;

                // Navigate to app
                navigateToApp();

                // Return to avoid running code after this block
                return;
            }

            // Alert user about invalid credentials and empty TextBox components
            MessageBox.Show("Invalid credentials, try again.");
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";
        }


    }
}
