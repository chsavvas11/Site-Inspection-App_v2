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
    public partial class InspectionOverview : UserControl
    {
        // Get instance of state 
        private State state = State.getState();

        public InspectionOverview()
        {
            InitializeComponent();
        }

        // Method triggered when page visible property is changed
        private void InspectionOverview_VisibleChanged(object sender, EventArgs e)
        {
            // Only load table if the visible property was changed to true
            if (this.Visible == true)
            {
                foreach (ChecksCategory checksCategory in Constants.CHECKS_CATEGORIES)
                {
                    string name = checksCategory.name;
                    int totalPositiveInterventions = 0;
                    int totalNegativeInterventions = 0;

                    foreach (CheckData checkData in state.CollectedCheckData)
                    {
                        // If check belongs to current category add interventions numbers
                        if (Array.Find(Constants.CHECKS, check => check.number == checkData.checkNumber).checkCategoryIndex == checksCategory.index)
                        {
                            totalPositiveInterventions += checkData.positiveInterventionAmount;
                            totalNegativeInterventions += checkData.negativeInterventionAmount;
                        }
                    }

                    // Add row with each category's data to DataGridView
                    categoryInterventionsDataGridView.Rows.Add(name, totalPositiveInterventions, totalNegativeInterventions);
                }
            }
        }

        // Submits inspection and navigates back to dashboard
        private void submitInspectionButton_Click(object sender, EventArgs e)
        {
            // Get comments from TextBox
            string comments = commentsTextBox.Text.Trim();

            // Check if comments is null or whitespace
            if (string.IsNullOrWhiteSpace(comments))
            {
                // Alert user
                MessageBox.Show("Please enter comments.");

                // Return to avoid running next code block
                return;
            }

            // Use db methods to add inspection to database
            DBConnection.getInstanceOfDBConnection().createInspection(Constants.NEW_INSPECTION_QUERY, state.CollectedInspectionInformation);
            DBConnection.getInstanceOfDBConnection().createInspectionChecks(Constants.NEW_INSPECTION_CHECK_QUERY, state.CollectedCheckData);
            
            // Announce success
            MessageBox.Show("Inspection has been added to the database");

            // Navigate back to dashboard
            Utils.navigateTo(((Panel)this.Parent).Controls, typeof(InspectorDashboard));
            this.Visible = false;

        }
    }
}
