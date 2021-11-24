using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace App
{
    class Utils
    {
        // Navigates to page of type in the control collection passed
        public static void navigateTo(ControlCollection cc, Type type)
        {
            // Loop through control collection
            foreach (Control c in cc)
            {
                // Check if the type of the control is equal to the type to match
                if (c.GetType() == type)
                {
                    // Make control visible and bring it to front
                    c.Visible = true;
                    c.BringToFront();
                }
            }
        }

        // Returns checks for category that matches index passed
        public static Check[] getChecksForCategory(char categoryIndex)
        {
            // Filter array to get checks that match the passed index
            Check[] checksForCategory = Constants.CHECKS.Where(check => check.checkCategoryIndex == categoryIndex).ToArray();
            
            // Return result
            return checksForCategory;
        }

        // Returns name of category that matches index passed
        public static string getCategoryName(char categoryIndex)
        {
            // Find category that matches index passed inside categories array
            ChecksCategory chosenCategory = Array.Find(Constants.CHECKS_CATEGORIES, category => category.index == categoryIndex);
            
            // Return result
            return chosenCategory.name;
        }

        // Returns number for check that matches name passed
        public static int getCheckNumberForName(string name)
        {
            // Find check whose name matches passed name
            Check chosenCheck = Array.Find(Constants.CHECKS, check => check.name == name);

            // Return result
            return chosenCheck.number;
        }

    }
}
