using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{

    // Check category class
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

    // Check class
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

    // Inspection information data class
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

        /* This method stores the inspection information in variables.
        The data will be fetched from the inspection information class */
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

    // Check data class
    class CheckData
    {
        // Variables for the check form are created
        // Get and set are used to retrieve data from the variables in the InspectionCategory class
        public string checkName { get; private set; }
        public int positiveInterventionAmount { get; private set; }
        public string positiveInterventionComments { get; private set; }
        public int negativeInterventionAmount { get; private set; }
        public string negativeInterventionComments { get; private set; }
        public bool isCompleted { get; private set; }

        public int checkNumber { get; private set; }

        // The checkData method takes all the data from the check form and stores it in variables
        public CheckData(string newCheckName, int newPositiveInterventionAmount, string newPositiveInterventionComments, int newNegativeInterventionAmount, string newNegativeInterventionComments, bool newIsCompleted, int newCheckNumber)
        {
            checkName = newCheckName;
            positiveInterventionAmount = newPositiveInterventionAmount;
            positiveInterventionComments = newPositiveInterventionComments;
            negativeInterventionAmount = newNegativeInterventionAmount;
            negativeInterventionComments = newNegativeInterventionComments;
            isCompleted = newIsCompleted;
            checkNumber = newCheckNumber;
        }

    }
}
