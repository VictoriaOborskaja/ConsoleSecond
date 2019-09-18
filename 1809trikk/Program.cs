using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1809trikk
{
    class Program
    {
        static void Main(string[] args)
        {   //SHOP
            List<food> groceries = new List<food>
            {
                new food ("banana", 1.2),
                new food ("potatoes", 1),
                new food ("icecream", 2.5),
            };

            //Client
            Console.WriteLine("Pleast enter your first name ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Hi, " + firstName + "! Please enter your last name: ");
            string lastName = Console.ReadLine();

            Person client = new Person(firstName, lastName);

            Console.WriteLine("Welcome to our shop, " + client + " !");
            client.ShoppingCart = new ShoppingCart();

            ChooseFood(groceries, client);
            while (Console.ReadLine() == "Y")
            {
                ChooseFood(groceries, client);
            }
            double sum = client.ShoppingCart.CalculateSum();
            Console.WriteLine("Your total is " + sum + " Thank you for visiting!");
        }

        private static void ChooseFood(List<food> groceries, Person client)
        {
            Console.WriteLine("What do you want to buy?");
            string foodName = Console.ReadLine();
            food chosenFood = groceries.FirstOrDefault(x => x.Name == foodName);
            if (chosenFood == null)
            {
                Console.WriteLine("Excuse me, we dont't have" + foodName + "in our shop.");

            }
            else
            {
                Console.WriteLine("How much?");
                string amount = Console.ReadLine();
                int a;
                bool success = int.TryParse(amount, out a);
                while (!success)
                {
                    Console.WriteLine("Escuse me, amount should be integer value: ");
                    amount = Console.ReadLine();
                    success = int.TryParse(amount, out a);
                }
                client.ShoppingCart.AddToCart(chosenFood, a);
            }
            Console.WriteLine("Anything else? Y/N");
        }
    }
}
