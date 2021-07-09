using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double discountStudio = 0.0;
            double discountApt = 0.0;
            double studio = 0.0;
            double apartment = 0.0;

            if (month == "May" || month == "October")
            {
                studio = 50 * nights;
                apartment = 65 * nights;
                if (nights > 7 && nights <=14)
                {
                    discountStudio = studio * 0.05;
                    studio = studio - discountStudio;
                }
                else if ( nights > 14)
                {
                    discountStudio = studio * 0.3;
                    discountApt = apartment * 0.1;
                    studio = studio - discountStudio;
                    apartment = apartment - discountApt;
                }
            }
            else if (month == "June" || month == "September")
            {
                studio = 75.20 * nights;
                apartment = 68.70 * nights;
                if (nights > 14)
                {
                    discountStudio = studio * 0.2;
                    studio = studio - discountStudio;
                    discountApt = apartment * 0.1;
                    apartment = apartment - discountApt;
                }
            }
            else if (month == "July" || month == "August")
            {
                studio = 76 * nights;
                apartment = 77 * nights;
                if (nights > 14)
                {
                    discountApt = apartment * 0.1;
                    apartment = apartment - discountApt;
                }
            }

            Console.WriteLine($"Apartment: {apartment:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");
        }
    }
}
