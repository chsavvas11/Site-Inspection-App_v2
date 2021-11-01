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

        public static State getState()
        {
            if (_instance == null)
                _instance = new State();
            return _instance;
        }
    }
}
