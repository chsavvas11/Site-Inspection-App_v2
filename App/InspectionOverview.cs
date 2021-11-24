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
    }
}
