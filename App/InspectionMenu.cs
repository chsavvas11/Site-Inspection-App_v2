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
        // Get instance of state 
        private State state = State.getState();
        public InspectionMenu()
        {
            InitializeComponent();
        }

        // Each button on the InspectionMenu page is assigned to a index value which is used to display the correct check options
        private void workingStandardsSelection_Click(object sender, EventArgs e)
        {
            state.ChosenCategoryIndex = 'A';
            Utils.navigateTo(((Panel)this.Parent).Controls, typeof(InspectionCategory));
        }

        private void qualitySelection_Click(object sender, EventArgs e)
        {
            state.ChosenCategoryIndex = 'B';
            Utils.navigateTo(((Panel)this.Parent).Controls, typeof(InspectionCategory));
        }

        private void siteRulesSelection_Click(object sender, EventArgs e)
        {
            state.ChosenCategoryIndex = 'C';
            Utils.navigateTo(((Panel)this.Parent).Controls, typeof(InspectionCategory));
        }

        private void environmentalSelection_Click(object sender, EventArgs e)
        {
            state.ChosenCategoryIndex = 'D';
            Utils.navigateTo(((Panel)this.Parent).Controls, typeof(InspectionCategory));
        }

        private void POISelection_Click(object sender, EventArgs e)
        {
            state.ChosenCategoryIndex = 'E';
            Utils.navigateTo(((Panel)this.Parent).Controls, typeof(InspectionCategory));
        }

        private void TCOESelection_Click(object sender, EventArgs e)
        {
            state.ChosenCategoryIndex = 'F';
            Utils.navigateTo(((Panel)this.Parent).Controls, typeof(InspectionCategory));
        }

        private void miscellaneousSelection_Click(object sender, EventArgs e)
        {
            state.ChosenCategoryIndex = 'G';
            Utils.navigateTo(((Panel)this.Parent).Controls, typeof(InspectionCategory));
        }

        private void CompleteInspectionButton_Click(object sender, EventArgs e)
        {
            Utils.navigateTo(((Panel)this.Parent).Controls, typeof(InspectionOverview));
        }
    }
}
