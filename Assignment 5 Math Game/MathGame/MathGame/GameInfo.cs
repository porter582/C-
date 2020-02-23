using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class GameInfo
    {
        public int gType;
        public string firstName;
        public string lastName;
        public int age;
        public bool gAdd()
        {
            gType = 1;
            return true;
        }

        public bool gSub()
        {
            gType = 2;
            return true;
        }

        public bool gMult()
        {
            gType = 3;
            return true;
        }

        public bool gDiv()
        {
            gType = 4;
            return true;
        }

        public bool gSubmitInfo(string fName, string lName, int fAge)
        {
            firstName = fName;
            lastName = lName;
            age = fAge;
            return true;
        }
    }
}
