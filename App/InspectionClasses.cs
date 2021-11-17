using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class ChecksCategory
    {
        public char index { get; private set; }
        public string name { get; private set; }

        public ChecksCategory(char newIndex, string newName)
        {
            index = newIndex;
            name = newName;
        }
    }

    class Check
    {
        public int number { get; private set; }
        public string name { get; private set; }
        public char checkCategoryIndex { get; private set; }

        public Check(int newNumber, string newName, char newCheckCategoryIndex)
        {
            number = newNumber;
            name = newName;
            checkCategoryIndex = newCheckCategoryIndex;
        }
    }

    class InspectionInformationData
    {
        //The following lines create variables and set their datatypes to store the user input, get and set are used to set their contents.
        public string site { get; private set; }
        public DateTime date { get; private set; }
        public string jobDescription { get; private set; }
        public string inspector { get; private set; }
        public string completedBy { get; private set; }
        public string workArea { get; private set; }
        public string supervisor { get; private set; }
        public string type { get; private set; }

        public InspectionInformationData(string newSite, DateTime newDate, string newJobDescription, string newInspector, string newCompletedBy, string newWorkArea, string newSupervisor, string newType)
        {
            site = newSite;
            date = newDate;
            jobDescription = newJobDescription;
            inspector = newInspector;
            completedBy = newCompletedBy;
            workArea = newWorkArea;
            supervisor = newSupervisor;
            type = newType;
        }

    }

    class CheckData
    {
        // Variables for the check form are created.
        public string numberOfInterventions { get; set; }
        public string comment { get; set; }
        public string completionStatus { get; set; }
        public string actionTaken { get; set; }


    }
}
