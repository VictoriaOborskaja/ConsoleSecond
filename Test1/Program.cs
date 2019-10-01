using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Group? TAR,TIT,LOG");
            var groupname = Console.ReadLine();
            Console.WriteLine(groupname);

            if (groupname == "TAR")
                using (StreamReader sr = new StreamReader("tar.txt"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                    Console.ReadLine();
                    

                }

            else if (groupname == "TIT")
                using (StreamReader sr = new StreamReader("tit.txt"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                    Console.ReadLine();
                }

            else if (groupname == "LOG")
                using (StreamReader sr = new StreamReader("log.txt"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                    Console.ReadLine();

                }

                
            else
                {
                    Console.WriteLine("We don't have this Group name");
                    Console.ReadLine();

                }

            Console.WriteLine("Would you like to add or delete student? Press 1 or 2 (1 is add, and 2 is delete)");
            var btn = Console.ReadLine();
            

            if (btn == "1")
            {
                Console.WriteLine("Please enter the name of sudent:");
                
                var answer = Console.ReadLine();
                Console.WriteLine("Thank you " + answer +  " is added");
                Console.ReadLine();
                string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
                using (StreamWriter file = new StreamWriter(path))
                {
                    file.WriteLine(answer);
                }



            }










            //List<Group_class> people = new List<Group_class>();
            // string[] lines = File.ReadAllLines(@"C: \Users\Victoria\Desktop\list.txt");

            //string[] lines = File.ReadAllLines("group1_list.txt");


            //foreach (var line in lines)
            // {
            //  var names = line.Split(' ');
            //   Group_class person = new Group_class(g);
            //   people.Add(person);
            //}

            // Console.WriteLine("Hi! Please enter Group Name");
            // string groupName = Console.ReadLine();

            //Group_class someone = people.FirstOrDefault(x => x.GroupName == lastName);
            //Console.WriteLine($"Hi, {someone.FirstName}! What's your favourite color?");
            //var answer = Console.ReadLine();

            //Enum.TryParse(answer, true, out Color favouriteColor);
            //someone.FavouriteColor = favouriteColor;

            //using (StreamWriter file = new StreamWriter("list2.txt"))
            //{
            // file.WriteLine($"{someone.FirstName} {someone.LastName} Favourite color: {someone.FavouriteColor}");
            //}

            //string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
            //using (StreamWriter file = new StreamWriter(path))
            //{
            //file.WriteLine($"{ someone.FirstName} {someone.LastName} Favourite color: {someone.FavouriteColor}");
            //}


        }
    }
}
