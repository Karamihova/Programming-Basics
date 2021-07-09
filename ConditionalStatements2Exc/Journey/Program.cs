using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double spentMoney = 0.0;
            string placeToStay = "";
            string destination = "";

            //calc

            if (budget <= 100)
            {
                switch (season)
                {
                    case "summer": spentMoney = budget * 0.30;
                        placeToStay = "Camp";
                        break;
                    case "winter": spentMoney = budget * 0.70;
                        placeToStay = "Hotel";
                        break;
                }

                destination = "Bulgaria";
            }
            else if (budget <= 1000)
            {
                switch (season)
                {
                    case "summer":
                        spentMoney = budget * 0.40;
                        placeToStay = "Camp";
                        break;
                    case "winter":
                        spentMoney = budget * 0.80;
                        placeToStay = "Hotel";
                        break;
                }

                destination = "Balkans";
            }
            else if (budget > 1000)
            {
                switch (season)
                {
                    case "summer":
                    case "winter":
                        spentMoney = budget * 0.90;
                        placeToStay = "Hotel";
                        break;
                }

                destination = "Europe";
            }

            //print

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{placeToStay} - {spentMoney:f2}");
        }
    }
}
