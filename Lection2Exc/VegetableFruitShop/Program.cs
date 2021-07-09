using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableFruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            double priceVegPerKg = double.Parse(Console.ReadLine());
            double priceFruitsPerKg = double.Parse(Console.ReadLine());

            int vegKg = int.Parse(Console.ReadLine());
            int fruitsKg = int.Parse(Console.ReadLine());

            //calc
            double veggies = priceVegPerKg * vegKg;
            double fruits = priceFruitsPerKg * fruitsKg;
            double totalPrice = (veggies+fruits)/1.94;

            //print
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
