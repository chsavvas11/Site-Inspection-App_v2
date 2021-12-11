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
    public partial class InspectionCategory : UserControl
    {
        // Get instance of state 
        private State state = State.getState();

        // Array created to store the selected checks.
        private Check[] checks;

        // Constructor
        public InspectionCategory()
        {
            InitializeComponent();
            // Display the name of the category being inspected at the top of the screen
            //categoryPageTitle.Text = Utils.getCategoryName(state.ChosenCategoryIndex);
        }

        // Adds items to dropdown
        private void checkSelectionDropDown_Click(object sender, EventArgs e)
        {
            // The 'checks' variable will hold the cehcks for the selected index
            checks = Utils.getChecksForCategory(state.ChosenCategoryIndex);
            // The .Clear function is being used to prevent the list from being appended with the same lists
            checkSelectionDropdown.Items.Clear();
            /* This for loop will go through the indexes and add only the indexes that are matching
            the chosenCategoryIndex to the dropdown menu */
            foreach (Check check in checks)
            {

                // Only add the check to the dropdown if it has not been completed already
                // Use double question mark operator to return empty array is no check data has been collected as the array in state is null initially
                if (!(state.CollectedCheckData ?? new CheckData[] {}).Select(checkData => checkData.checkName).ToArray().Contains(check.name))
                {
                    checkSelectionDropdown.Items.Add(check.name);
                }
            }
    
        }

        // Navigates back to inspection menu
        private void backButton_Click(object sender, EventArgs e)
        {
            // Clicking the back button with call the navigateTo function to go back to the previous page
            Utils.navigateTo(((Panel)this.Parent).Controls, typeof(InspectionMenu));
            this.Visible = false;
        }

        // The saveCheckButton_click even will result in the user inputs being saved to variables and then being sent to the CheckData class
        private void saveCheckButton_Click(object sender, EventArgs e)
        {


            

            string checkName = checkSelectionDropdown.Text;
            string positiveInterventionAmount = positiveInterventionAmountTextBox.Text;
            string positiveInterventionComments = positiveInterventionCommentsTextBox.Text;
            string negativeInterventionAmount = NegativeInterventionAmountTextBox.Text;
            string negativeInterventionComments = NegativeInterventionCommentsTextBox.Text;
            string isCompleted = IsCompletedTextBox.Text;
      

            // Input validation.

            if (String.IsNullOrWhiteSpace(checkName) ||
                (String.IsNullOrWhiteSpace(positiveInterventionAmount) && !int.TryParse(positiveInterventionAmount, out int i)) ||
                String.IsNullOrWhiteSpace(positiveInterventionComments) ||
                (String.IsNullOrWhiteSpace(positiveInterventionAmount) && !int.TryParse(negativeInterventionAmount, out int j)) ||
                String.IsNullOrWhiteSpace(negativeInterventionComments) ||
                String.IsNullOrWhiteSpace(isCompleted))

            {
                MessageBox.Show("All fields marked with * must be filled");
            }
            else
            {
                int negativeInterventionAmountInt = int.Parse(negativeInterventionAmount);
                int positiveInterventionAmountInt = int.Parse(positiveInterventionAmount);


                // Use util to get check number
                int checkNumber = Utils.getCheckNumberForName(checkName);

                // Create new CheckData object
                CheckData checkData = new CheckData(checkName, positiveInterventionAmountInt, positiveInterventionComments, negativeInterventionAmountInt, negativeInterventionComments, isCompleted == "Yes" ? true : false, checkNumber);

                // Store CheckData object to state using ternary operators
                state.CollectedCheckData = (state.CollectedCheckData == null)
                    ? new CheckData[] { checkData }
                    : state.CollectedCheckData.Concat(new CheckData[] { checkData }).ToArray();

                // The .Clear function is used to clear the input boxes for the next check form
                positiveInterventionAmountTextBox.Clear();
                positiveInterventionCommentsTextBox.Clear();
                NegativeInterventionAmountTextBox.Clear();
                NegativeInterventionCommentsTextBox.Clear();
                // This will make sure that the selected option is not saved on the combobox for the next check
                checkSelectionDropdown.SelectedIndex = -1;
                IsCompletedTextBox.SelectedIndex = -1;

                Utils.navigateTo(((Panel)this.Parent).Controls, typeof(InspectionMenu));

                this.Visible = false;

            }
        }

        // Changes the category name when it's turned back to visible
        private void InspectionCategory_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)

            {
                categoryPageTitle.Text = Utils.getCategoryName(state.ChosenCategoryIndex);

            }

        }

        // Type checks when user leaves textbox
        private void PositiveInterventionAmountTextBox_Leave(object sender, EventArgs e)
        {
            lbPositiveInterventions.Visible = false;

            // Try and catch is used to deal with the integer exception
            try
            {
                // .Parse just checks if an integer is entered
                int.Parse(positiveInterventionAmountTextBox.Text);
            }
            catch
            {
                // If an integer is not entered, the user will be alerted. They will not be able to move to the next box until they enter an integer.
                MessageBox.Show("An integer must be entered for intervention amount");
                positiveInterventionAmountTextBox.Focus();
                // A message will be displayed next to the box the user needs to fill in.
                lbPositiveInterventions.Visible = true;
                // Once the user successfully enters a integer they can continue to fill in the next box.
                // Return is used to do this.
                return;
            }
        }

        // Type checks when user leaves textbox
        private void NegativeInterventionAmountTextBox_Leave(object sender, EventArgs e)
        {
            lbNegativeInterventions.Visible = false;
            // Try and catch is used to deal with the integer exception
            try
            {
                // .Parse just checks if an integer is entered
                int.Parse(NegativeInterventionAmountTextBox.Text);
            }
            catch
            {
                // If an integer is not entered, the user will be alerted. They will not be able to move to the next box until they enter an integer.
                MessageBox.Show("An integer must be entered for intervention amount");
                NegativeInterventionAmountTextBox.Focus();
                // A message will be displayed next to the box the user needs to fill in.
                lbNegativeInterventions.Visible = true;
                // Once the user successfully enters a integer they can continue to fill in the next box.
                // Return is used to do this.
                return;
            }

        }
    }
}
