using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruiseShip
{
    class Program
    {
        static void Main(string[] args)
        {
            string cruiseType = Console.ReadLine();
            string cabinType = Console.ReadLine();
            int stayNights = int.Parse(Console.ReadLine());

            double pricePerNight = 0.0;

            if (cruiseType == "Mediterranean")
            {
                switch (cabinType)
                {
                    case "standard cabin":
                        pricePerNight = 27.50;
                        break;
                    case "cabin with balcony":
                        pricePerNight = 30.20;
                        break;
                    case "apartment":
                        pricePerNight = 40.50;
                        break;
                }
            }
            else if( cruiseType == "Adriatic")
            {
                switch (cabinType)
                {
                    case "standard cabin":
                        pricePerNight = 22.99;
                        break;
                    case "cabin with balcony":
                        pricePerNight = 25.00;
                        break;
                    case "apartment":
                        pricePerNight = 34.99;
                        break;
                }
            }
            else
            {
                switch (cabinType)
                {
                    case "standard cabin":
                        pricePerNight = 23.00;
                        break;
                    case "cabin with balcony":
                        pricePerNight = 26.60;
                        break;
                    case "apartment":
                        pricePerNight = 39.80;
                        break;
                }
            }

            double totalMoney = pricePerNight * stayNights * 4;
            if (stayNights > 7)
            {
                totalMoney = totalMoney - (totalMoney * 0.25);
            }
            Console.WriteLine($"Annie's holiday in the {cruiseType} sea costs {totalMoney:f2} lv.");
        }
    }
}
