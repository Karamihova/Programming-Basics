using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double coffee = 0;
            double water = 0;
            double beer = 0;
            double sweets = 0;
            double peanuts = 0;

            if (city=="Sofia")
            {
                coffee = 0.50;
                water = 0.80;
                beer = 1.20;
                sweets = 1.45;
                peanuts = 1.60;

                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(quantity * coffee);
                        break;
                    case "water":
                        Console.WriteLine(quantity * water);
                        break;
                    case "beer":
                        Console.WriteLine(quantity * beer);
                        break;
                    case "sweets":
                        Console.WriteLine(quantity * sweets);
                        break;
                    case "peanuts":
                        Console.WriteLine(quantity * peanuts);
                        break;
                }

            }
            else if (city == "Plovdiv")
            {
                coffee = 0.40;
                water = 0.70;
                beer = 1.15;
                sweets = 1.30;
                peanuts = 1.50;

                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(quantity * coffee);
                        break;
                    case "water":
                        Console.WriteLine(quantity * water);
                        break;
                    case "beer":
                        Console.WriteLine(quantity * beer);
                        break;
                    case "sweets":
                        Console.WriteLine(quantity * sweets);
                        break;
                    case "peanuts":
                        Console.WriteLine(quantity * peanuts);
                        break;
                }

            }
            else if (city == "Varna")
            {
                coffee = 0.45;
                water = 0.70;
                beer = 1.10;
                sweets = 1.35;
                peanuts = 1.55;

                switch (product)
                {
                    case "coffee":
                        Console.WriteLine(quantity * coffee);
                        break;
                    case "water":
                        Console.WriteLine(quantity * water);
                        break;
                    case "beer":
                        Console.WriteLine(quantity * beer);
                        break;
                    case "sweets":
                        Console.WriteLine(quantity * sweets);
                        break;
                    case "peanuts":
                        Console.WriteLine(quantity * peanuts);
                        break;
                }
            }
        }
    }
}
