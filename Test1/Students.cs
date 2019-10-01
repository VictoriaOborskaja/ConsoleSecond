using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Students
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Students(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

        }

        public Students()
        {
        }

        public override string ToString()
        {
            return FirstName + "" + LastName;
        }
    }
}
