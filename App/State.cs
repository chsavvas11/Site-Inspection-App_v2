using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class State
    {
        // Store instance
        private static State _instance;

        // Store username of user currently logged in
        public string Username { get; set; }

        // Store access level of user currently logged in
        public string AccessLevel { get; set; }

        // The below variable will store the inspectors category choice.
        public char ChosenCategoryIndex { get; set; }

        // Array to store inspection information from form
        public InspectionInformationData CollectedInspectionInformation { get; set; }

        // Array to store check data from the check forms
        public CheckData[] CollectedCheckData { get; set; }

        // Returns instance of state to maintain the same variables
        public static State getState()
        {
            if (_instance == null)
                _instance = new State();
            return _instance;
        }

       
    }


}
