using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingBoat2
{
    class Program
    {
        static void Main(string[] args)
        {
            //print
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fisherMen = int.Parse(Console.ReadLine());
            double shipPrice = 0.0;

            //calc

            if (season == "Spring")
            {
                shipPrice = 3000;
            }
            else if ( season == "Summer" || season == "Autumn")
            {
                shipPrice = 4200;
            }
            else if (season == "Winter")
            {
                shipPrice = 2600;
            }

            if (fisherMen <= 6 )
            {
                shipPrice = shipPrice - (shipPrice * 0.10);
            }
            else if ( fisherMen >= 7 && fisherMen <= 11)
            {
                shipPrice = shipPrice - (shipPrice * 0.15);

            }
            else if (fisherMen >= 12)
            {
                shipPrice = shipPrice - (shipPrice * 0.25);

            }

            if (fisherMen % 2 == 0)
            {
                switch (season)
                {
                    case "Summer":
                    case "Spring":
                    case "Winter":
                        shipPrice = shipPrice - (shipPrice * 0.05);
                        break;
                }
            }

            if (budget >= shipPrice)
            {
                Console.WriteLine($"Yes! You have {budget - shipPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {shipPrice - budget:f2} leva.");
            }
        }
    }
}
