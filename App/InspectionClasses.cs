using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class ChecksCategory
    {
        public static char index;
        public static string name;

        public ChecksCategory(char newIndex, string newName)
        {
            index = newIndex;
            name = newName;
        }
    }

    class Check
    {
        public static int number;
        public static string name;
        public static char checkCategoryIndex;

        public Check(int newNumber, string newName, char newCheckCategoryIndex)
        {
            number = newNumber;
            name = newName;
            checkCategoryIndex = newCheckCategoryIndex;
        }
    }
}
