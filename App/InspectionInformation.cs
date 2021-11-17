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
    public partial class InspectionInformation : UserControl
    {

        //calling the state class
        private State state = State.getState();
        public InspectionInformation()
        {
            InitializeComponent();
        }

        private void informationSaveButton_Click(object sender, EventArgs e)
        {
            // Test to make sure input is being recieved.
            //MessageBox.Show($"The site {siteTextbox.Text} is being inspected");

            string site = siteTextbox.Text;
            string workArea = workAreaTextBox.Text;
            string supervisor = supervisorTextBox.Text;
            string type = typeTextBox.Text;
            string completedBy = completedByTextBox.Text;
            string jobDescription = jobDescriptionTextBox.Text;
            string inspector = inspectorTextBox.Text;
            DateTime date = dateSelector.Value.Date;

            //Validation
            // All entry text boxes are checked to see if they are empty
            // Date selctor is always pre filled in, therefore date field does not need checking
            if (String.IsNullOrWhiteSpace(site) ||
               String.IsNullOrWhiteSpace(workArea) ||
               String.IsNullOrWhiteSpace(supervisor) ||
               String.IsNullOrWhiteSpace(type) ||
               String.IsNullOrWhiteSpace(completedBy) ||
               String.IsNullOrWhiteSpace(jobDescription) ||
               String.IsNullOrWhiteSpace(inspector))
            {
                // A message will be displayed if any of the entry fields remain empty
                MessageBox.Show("Please make sure that all fields are completed");
                return;
            }
            else
            {
                /* If all fields are complete the entered data will be saved in the global variables in InspectionClasses
                   and the categories selection page will appear */
                InspectionInformationData inspectionInformation = new InspectionInformationData(site, date, supervisor, type, completedBy, jobDescription, inspector, workArea);
                Utils.navigateTo(((Panel)this.Parent).Controls, typeof(InspectionCategory));
            }



            // This will create an object of the inspectioninfodata class and send all the textbox data to the variables in that data class
            //InspectionInformationData inspectionInformation = new InspectionInformationData(site, date, supervisor, type, completedBy, jobDescription, inspector, workArea);
            // This sets all the collected info to state
            //state.CollectedInspectionInformation = InspectionInformation;

        }
    }
}
