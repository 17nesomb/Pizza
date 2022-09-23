using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> toppings = new List<string> {
                "Pepperoni", "Margerita", "Hawaiian"
            };


            string selection = ChooseFrom(toppings);
            Console.WriteLine($"You've chosen {selection}");
        }

        private static string ChooseFrom(List<string> options)
        {
            bool valid = false;
            string choice = "";

            Console.WriteLine("What pizza would you like we have: ");
            for (int i = 0; i < options.Count; i ++)
            {
                Console.WriteLine($"{i+1} : {options[i]}");

            }

            while (valid == false)
            {
                Console.WriteLine($"Enter a number from 1 - {options.Count}");
                choice = Console.ReadLine();
                
                
            }
            int intChoice = int.Parse(choice);
            return (options[intChoice - 1]);
        }

    }
}
