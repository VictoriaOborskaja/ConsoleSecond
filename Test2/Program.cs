using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> NewGroup = new List<Student>
            {
                new Student("Ivan","Petrov",false,5),
                new Student ("Irina", "Ivanova", false,5),
                new Student ("Trinu", "Kallas", false,2)
             };

            Group group = new Group();

            for (int i = 0; i < NewGroup.Count; i++)
            {
                group.TARgve18.Add(NewGroup[i]);

                Console.WriteLine(group.TARgve18[i].FirstName + " " + group.TARgve18[i].LastName);
            }
        }

    }
}
