using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingBoat //  judge - 60/100 = greshka pri otstupka 5 % e 0.05, a ne 0.5 !!!!!!!!!!!
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermenCount = int.Parse(Console.ReadLine());
            double shipPrice = 0.0;
            double discount = 0.0;

            //calc

            switch (season)
            {
                case "Spring": shipPrice = 3000;
                    break;
                case "Summer":
                case "Autumn": shipPrice = 4200;
                    break;
                case "Winter": shipPrice = 2600;
                    break;
            }

            if (fishermenCount <= 6)
            {
                discount = shipPrice * 0.1;
                shipPrice = shipPrice - discount;
            }
            else if (fishermenCount >= 7 && fishermenCount <= 11)
            {
                discount = shipPrice * 0.15;
                shipPrice = shipPrice - discount;
            }
            else if (fishermenCount >= 12)
            {
                discount = shipPrice * 0.25;
                shipPrice = shipPrice - discount;
            }

            if (fishermenCount % 2 == 0)
            {
                if (season == "Summer" || season == "Spring" || season == "Winter")
                {
                    shipPrice = shipPrice - (shipPrice * 0.05);
                }
                else if (season == "Autumn")
                {
                    
                }
            }


            //print

            if (budget >= shipPrice)
            {
                Console.WriteLine($"Yes! You have {budget - shipPrice :f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {shipPrice - budget :f2} leva.");
            }
        }
    }
}
