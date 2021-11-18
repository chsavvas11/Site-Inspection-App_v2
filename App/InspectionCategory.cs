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
        private State state = State.getState();

        // Array created to store the selected checks.
        private Check[] checks;

        public InspectionCategory()
        {
            InitializeComponent();
            // Display the name of the category being inspected at the top of the screen
            //categoryPageTitle.Text = Utils.getCategoryName(state.ChosenCategoryIndex);
        }

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
                checkSelectionDropdown.Items.Add(check.name);
            }
    
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            // Clicking the back button with call the navigateTo function to go back to the previous page
            Utils.navigateTo(((Panel)this.Parent).Controls, typeof(InspectionMenu));
        }

        // The saveCheckButton_click even will result in the user inputs being saved to variables and then being sent to the CheckData class
        private void saveCheckButton_Click(object sender, EventArgs e)
        {
            string selectedCheck = checkSelectionDropdown.Text;
            string positiveInterventionAmount = positiveInterventionAmountTextBox.Text;
            string positiveInterventionComments = positiveInterventionCommentsTextBox.Text;
            string negativeInterventionAmount = NegativeInterventionAmountTextBox.Text;
            string negativeInterventionComment = NegativeInterventionCommentsTextBox.Text;
            string isCompleted = IsCompletedTextBox.Text;

            CheckData checkDetails = new CheckData(selectedCheck, positiveInterventionAmount,positiveInterventionComments, negativeInterventionAmount, negativeInterventionComment, isCompleted);

            // The .Clear function is used to clear the input boxes for the next check form
            positiveInterventionAmountTextBox.Clear();
            positiveInterventionCommentsTextBox.Clear();
            NegativeInterventionAmountTextBox.Clear();
            NegativeInterventionCommentsTextBox.Clear();
            // This will make sure that the selected option is not saved on the combobox for the next check
            checkSelectionDropdown.SelectedIndex = -1;
            IsCompletedTextBox.SelectedIndex = -1;

            Utils.navigateTo(((Panel)this.Parent).Controls, typeof(InspectionMenu));

            //MessageBox.Show($"The following chech has been completed{selectedCheck} ");
            // MessageBox.Show($"The site {siteTextbox.Text} is being inspected");
        }
    }
}
