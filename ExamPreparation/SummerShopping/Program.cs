using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            //read
            int budget = int.Parse(Console.ReadLine());
            double towelPrice = double.Parse(Console.ReadLine());
            int discountPercent = int.Parse(Console.ReadLine());

            //count 
            double umbrellaPrice = 1.0 * 2 / 3 * towelPrice;
            double flipflopsPrice = 0.75 * umbrellaPrice;
            double bagPrice = 1.0 * 1 / 3 * (flipflopsPrice + towelPrice);
            double totalSum = towelPrice + umbrellaPrice + flipflopsPrice + bagPrice;
            totalSum = totalSum - (totalSum * (discountPercent / 100.0));

            //print
            if (budget >= totalSum)
            {
                Console.WriteLine($"Annie's sum is {totalSum:f2} lv. She has {(budget - totalSum):f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Annie's sum is {totalSum:f2} lv. She needs {(totalSum - budget):f2} lv. more.");
            }
        }
    }
}
