using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Constants
    {
        // Access levels
        public static string ADMIN = "ADMIN";
        public static string INSPECTOR = "INSPECTOR";

        // Inspection Categories
        public static ChecksCategory[] CHECKS_CATEGORIES =
        {
            new ChecksCategory('A', "Working Standards"),
            new ChecksCategory('B', "Quality"),
            new ChecksCategory('C', "Site Rules"),
            new ChecksCategory('D', "Environmental"),
            new ChecksCategory('E', "Protection Of Individuals"),
            new ChecksCategory('F', "Tools, Cables & Other Equipment"),
            new ChecksCategory('G', "Miscellaneous")
        };

        public static Check[] CHECKS = {
            new Check(1, "Work At Height", 'A'),
            new Check(2, "Lifting Operations - Crane, Fork Lift Truck, Hoists etc", 'A'),
            new Check(3, "Certification - Daily Checksheets for MEWP and FLT", 'A'),
            new Check(4, "Confined Space Work", 'A'),
            new Check(5, "Electrical Work", 'A'),
            new Check(6, "Site Set Up & Appearance, Signage", 'B'),
            new Check(7, "Paperwork (Permits, Risk Assessments, Method Statement)", 'B'),
            new Check(8, "Certification - Training, Insurance Inspection, Induction Current", 'B'),
            new Check(9, "Hot Work", 'C'),
            new Check(10, "Isolation and Lock Offs", 'C'),
            new Check(11, "Fire Exits and Escape Routes", 'C'),
            new Check(12, "Awareness - Fire Exit, Assembly Point", 'C'),
            new Check(13, "Waste Management", 'D'),
            new Check(14, "Product Contamination", 'D'),
            new Check(15, "COSHH & Asbestos", 'D'),
            new Check(16, "PPE", 'E'),
            new Check(17, "Manual Handling", 'E'),
            new Check(18, "Other Contractors", 'E'),
            new Check(19, "Power Tools, Cables & Other Equipment", 'F'),
            new Check(20, "Voltage Detector Checked", 'F'),
            new Check(21, "Tools Used Fit For Purpose", 'F'),
            new Check(22, "Company Vehicles", 'G'),
            new Check(23, "Fire Precautions", 'G'),
            new Check(24, "Workshop Conditions", 'G'),
        };
    }
}
