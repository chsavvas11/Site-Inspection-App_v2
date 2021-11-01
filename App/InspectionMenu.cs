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
    public partial class InspectionMenu : UserControl
    {
        public InspectionMenu()
        {
            InitializeComponent();
        }

        private void newInspection_Click(object sender, EventArgs e)
        {
            //to confirm use of navigateTo method
            //Utils.navigateTo(InspectionInformation);
        }

        private void viewInspections_Click(object sender, EventArgs e)
        {
            //to confirm use of navigateTo method
            //Utils.navigateTo(InspectionsList);
        }
    }
}
