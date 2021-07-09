using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlchoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            double whiskeyPricePerL = double.Parse(Console.ReadLine());
            double beerLiters = double.Parse(Console.ReadLine());
            double whineLiters = double.Parse(Console.ReadLine());
            double rakiaLiters = double.Parse(Console.ReadLine());
            double whiskeyLiters = double.Parse(Console.ReadLine());

            //calc

            double whiskey = whiskeyPricePerL * whiskeyLiters;

            double rakiaPricePerL = whiskeyPricePerL / 2;
            double rakia = rakiaPricePerL * rakiaLiters;

            double whinePricePerL = rakiaPricePerL - (0.4*rakiaPricePerL);
            double whine = whinePricePerL * whineLiters;

            double beerPricePerL = rakiaPricePerL - (0.8*rakiaPricePerL);
            double beer = beerPricePerL * beerLiters;

            double totalPrice = whiskey + rakia + whine + beer;
            

            //print
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
