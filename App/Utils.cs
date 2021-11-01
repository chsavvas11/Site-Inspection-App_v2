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
    }
}
