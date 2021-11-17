using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class State
    {
        private static State _instance;

        public string Username { get; set; }
        public string AccessLevel { get; set; }

        //public InspectionInformationData CollectedInspectionInformation{ get; set; }

        // The below variable will store the inspectors category choice.
        public char ChosenCategoryIndex { get; set; }


        public static State getState()
        {
            if (_instance == null)
                _instance = new State();
            return _instance;
        }

        // look at example from inspector information/////

       
    }


}
