using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoneyHarvest
{
    class Program
    {
        static void Main(string[] args)
        {
            //read
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double harvestedHoney = 0.0;
            //count
            if (season == "Spring")
            {
                switch (flowerType)
                {
                    case "Sunflower":
                        harvestedHoney = flowerCount * 10;
                        break;
                    case "Daisy":
                        harvestedHoney = flowerCount * 12;
                        harvestedHoney = harvestedHoney + (harvestedHoney * 0.10);
                        break;
                    case "Lavender":
                        harvestedHoney = flowerCount * 12;
                        break;
                    case "Mint":
                        harvestedHoney = flowerCount * 10;
                        harvestedHoney = harvestedHoney + (harvestedHoney * 0.10);
                        break;
                }
            }
            else if (season == "Summer")
            {
                switch (flowerType)
                {
                    case "Sunflower":
                        harvestedHoney = flowerCount * 8;
                        break;
                    case "Daisy":
                        harvestedHoney = flowerCount * 8;
                        break;
                    case "Lavender":
                        harvestedHoney = flowerCount * 8;
                        break;
                    case "Mint":
                        harvestedHoney = flowerCount * 12;
                        break;
                }

                harvestedHoney = harvestedHoney + (harvestedHoney * 0.10);
            }
            else
            {
                switch (flowerType)
                {
                    case "Sunflower":
                        harvestedHoney = flowerCount * 12;
                        break;
                    case "Daisy":
                        harvestedHoney = flowerCount * 6;
                        break;
                    case "Lavender":
                        harvestedHoney = flowerCount * 6;
                        break;
                    case "Mint":
                        harvestedHoney = flowerCount * 6;
                        break;
                }

                harvestedHoney = harvestedHoney - (harvestedHoney * 0.05);
            }

            //print
            Console.WriteLine($"Total honey harvested: {harvestedHoney:f2}");
        }
    }
}
