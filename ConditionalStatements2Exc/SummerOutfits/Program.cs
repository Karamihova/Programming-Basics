using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerOutfits
{
    class Program
    {
        static void Main(string[] args)
        {
            int weather = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            string outfit = "";
            string shoes = "";

            if (weather >= 10 && weather <= 42)
            {

                if (dayTime == "Morning")
                {
                    if (weather >= 10 && weather <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (weather > 18 && weather <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (weather >= 25)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                }
                else if (dayTime == "Afternoon")
                {
                    if (weather >= 10 && weather <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (weather > 18 && weather <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (weather >= 25)
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                }
                else if (dayTime == "Evening")
                {
                    if (weather >= 10 && weather <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (weather > 18 && weather <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (weather >= 25)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                }
            }
            Console.WriteLine($"It's {weather} degrees, get your {outfit} and {shoes}.");
        }
    }
}
