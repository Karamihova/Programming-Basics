using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            //calc and print

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    switch (fruit)
                    {
                        case "banana": Console.WriteLine($"{(quantity * 2.50):f2}"); break;
                        case "apple": Console.WriteLine($"{(quantity * 1.20):f2}"); break;
                        case "orange": Console.WriteLine($"{(quantity * 0.85):f2}"); break;
                        case "kiwi": Console.WriteLine($"{(quantity * 2.70):f2}"); break;
                        case "grapefruit": Console.WriteLine($"{(quantity * 1.45):f2}"); break;
                        case "pineapple": Console.WriteLine($"{(quantity * 5.50):f2}"); break;
                        case "grapes": Console.WriteLine($"{(quantity * 3.85):f2}"); break;
                        default: Console.WriteLine("error"); break;
                    }
                    break;
                case "Saturday":
                case "Sunday":
                    switch (fruit)
                    {
                        case "banana": Console.WriteLine($"{(quantity * 2.70):f2}"); break;
                        case "apple": Console.WriteLine($"{(quantity * 1.25):f2}"); break;
                        case "orange": Console.WriteLine($"{(quantity * 0.90):f2}"); break;
                        case "kiwi": Console.WriteLine($"{(quantity * 3.00):f2}"); break;
                        case "grapefruit": Console.WriteLine($"{(quantity * 1.60):f2}"); break;
                        case "pineapple": Console.WriteLine($"{(quantity * 5.60):f2}"); break;
                        case "grapes": Console.WriteLine($"{(quantity * 4.20):f2}"); break;
                        default: Console.WriteLine("error"); break;
                    }
                    break;
                default: Console.WriteLine("error"); break;


            }



        }
    }
}
