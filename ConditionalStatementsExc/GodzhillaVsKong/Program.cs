using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GodzhillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            double budget = double.Parse(Console.ReadLine());
            int stuntMen = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());

            //calc

            double clothing = stuntMen * clothingPrice;
            double decour = budget * 0.1;

            if (stuntMen>150)
            {
                clothing = clothing - (clothing * 0.1);
            }

            if (decour+clothing>budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(decour + clothing) - budget:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-(clothing+decour):F2} leva left.");
            }

            


        }
    }
}
