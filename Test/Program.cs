using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> NewGroup = new List<Student>
            {
                new Student("Marina","Petrova",false,4),
                new Student ("Fjodor", "Fjodorov", false,3),
                new Student ("Ivan", "Ivanov", false,5)
             };

            Group group = new Group();

            for (int i = 0; i < NewGroup.Count; i++)
            {
                group.TAR.Add(NewGroup[i]);

                Console.WriteLine(group.TAR[i].FirstName + " " + group.TAR[i].LastName);
            }
        }

    }
}

