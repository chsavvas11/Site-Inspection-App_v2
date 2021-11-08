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
}
