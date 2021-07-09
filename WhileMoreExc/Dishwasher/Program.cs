using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            //read
            int detergent = int.Parse(Console.ReadLine());
            int detergentQuantity = detergent * 750;
            int washedPlate = 0;
            int washedPot = 0;
            string input = Console.ReadLine();
            int count = 1;
            int washedDishes = 0;
            //calc
            while (input != "End")
            {
                int dishesCount = int.Parse(input);
                if (count % 3 == 0)
                {
                    washedPot += dishesCount;
                    dishesCount = dishesCount * 15;
                    washedDishes += dishesCount;
                }
                else
                {
                    washedPlate += dishesCount;
                    dishesCount = dishesCount * 5;
                    washedDishes += dishesCount;
                }

                if (washedDishes > detergentQuantity)
                {
                    break;
                }

                count++;
                input = Console.ReadLine();
            }
            //print
            if (washedDishes > detergentQuantity)
            {
                Console.WriteLine($"Not enough detergent, {washedDishes - detergentQuantity} ml. more necessary!");
            }
            else
            {
                Console.WriteLine($"Detergent was enough!");
                Console.WriteLine($"{washedPlate} dishes and {washedPot} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergentQuantity - washedDishes} ml.");
            }
        }
    }
}
