using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            int daysToStay = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string rating = Console.ReadLine();

            //calc

            double roomForOne = 18.00;
            double apartment = 25.00;
            double presidentApt = 35.00;

            daysToStay = daysToStay - 1;

            double price = 0.0;

            switch (typeRoom)
            {
                case "room for one person": price = daysToStay * roomForOne; break;
                case "apartment": price = daysToStay * apartment; break;
                case "president apartment": price = daysToStay * presidentApt; break;
                default:break;
            }

            if (typeRoom == "apartment")
            {
                if (daysToStay < 10)
                {
                    price = price - (price * 0.30);
                }
                else if ( daysToStay >=10 && daysToStay <= 15)
                {
                    price = price - (price * 0.35);
                }
                else if (daysToStay > 15)
                {
                    price = price - (price * 0.50);

                }
            }
            else if (typeRoom == "president apartment")
            {
                if (daysToStay < 10)
                {
                    price = price - (price * 0.10);
                }
                else if (daysToStay >= 10 && daysToStay <= 15)
                {
                    price = price - (price * 0.15);
                }
                else if (daysToStay > 15)
                {
                    price = price - (price * 0.20);

                }
            }

            if (rating == "positive")
            {
                price = price + (price * 0.25);
            }
            else if (rating == "negative")
            {
                price = price - (price * 0.10);
            }

            Console.WriteLine($"{price:f2}");
        }
    }
}
