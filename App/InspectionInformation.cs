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
        public InspectionInformation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Test to make sure input is being recieved.
            MessageBox.Show($"The site {site.Text} is being inspected");

        }
    }
}
