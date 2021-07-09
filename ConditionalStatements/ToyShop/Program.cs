using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //input
            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzlCount = int.Parse(Console.ReadLine());
            int dollCount = int.Parse(Console.ReadLine());
            int bearCount = int.Parse(Console.ReadLine());
            int mignCount = int.Parse(Console.ReadLine());
            int truckCount = int.Parse(Console.ReadLine());

            double puzzle = 2.60*puzzlCount;
            double doll = 3*dollCount;
            double teddyBear = 4.10*bearCount;
            double mignon = 8.20*mignCount;
            double truck = 2*truckCount;

            // calc 
            double orderPrice = puzzle + doll + teddyBear + mignon + truck;
            double numberSelledToys = puzzlCount + dollCount + bearCount + mignCount + truckCount;

            if (numberSelledToys >= 50 )
            {
                orderPrice = orderPrice - (orderPrice*0.25);
            }

            orderPrice = orderPrice - (orderPrice*0.10);

            //print
            if (vacationPrice <= orderPrice)
            {
                double moneyLeft = orderPrice - vacationPrice;
                Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
            }
            else
            {
                double moneyNeeded = vacationPrice - orderPrice;
                Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
            }
        }
    }
}
