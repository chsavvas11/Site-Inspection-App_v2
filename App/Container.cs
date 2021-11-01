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
        private State state = State.getState();

        private void navigateToLogIn()
        {
            this.Hide();
            (new LoginForm()).Show();
        }

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

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            navigateToLogIn();
        }
    }
}
