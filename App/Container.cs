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
    public partial class Container : Form
    {
        // Get instance of state 
        private State state = State.getState();

        // Navigates to login form
        private void navigateToLogIn()
        {
            this.Hide();
            (new LoginForm()).Show();
        }

        // Constructor
        // Determines which dashboard to show
        public Container()
        {
            InitializeComponent();
            UsernameLabel.Text = state.Username;

            if (state.AccessLevel == Constants.ADMIN)
            {
                if (InspectorDashboard.Visible == true)
                    InspectorDashboard.Visible = false;

                AdminDashboard.Visible = true;
                AdminDashboard.BringToFront();

            } else if (state.AccessLevel == Constants.INSPECTOR)
            {
                if (AdminDashboard.Visible == true)
                    AdminDashboard.Visible = false;

                InspectorDashboard.Visible = true;
                InspectorDashboard.BringToFront();
            }
        }

        // Navigates back to login
        private void LogOutButton_Click(object sender, EventArgs e)
        {
            navigateToLogIn();
        }
    }
}
