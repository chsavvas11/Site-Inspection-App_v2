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
    public partial class InspectorDashboard : UserControl
    {
        public InspectorDashboard()
        {
            InitializeComponent();
        }

        private void newInspectionButton_Click(object sender, EventArgs e)
        {
            /* When the new inspection button is clicked, the "navigateTo" method is called to bring
            the new selected control forward. */
            Utils.navigateTo(((Panel)this.Parent).Controls, typeof(InspectionInformation));
        }

    }
}
