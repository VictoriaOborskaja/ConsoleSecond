using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsStudying { get; set; }
        public int Value { get; set; }

        public Student(string firstName, string lastName, bool isStudying, int value)
        {
            FirstName = firstName;
            LastName = lastName;
            IsStudying = isStudying;
            Value = value;
        }

    }
}