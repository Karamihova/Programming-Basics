using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookingCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int competitorsCount = int.Parse(Console.ReadLine());

            int bakingCount = 0;
            double raisedMoney = 0;
            int cookiesCount = 0;
            int cakesCount = 0;
            int wafflesCount = 0;
            string competitorName = "";
            string baking = "";

            for (int i = 1; i <= competitorsCount; i++)
            {
            string input = Console.ReadLine();
                baking = Console.ReadLine();

                while (baking != "Stop baking!")
                {
                    competitorName = input;
                    int bakedCount = int.Parse(Console.ReadLine());
                    bakingCount += bakedCount;

                    switch (baking)
                    {
                        case "cookies":
                            raisedMoney += 1.0 * bakedCount * 1.50;
                            cookiesCount += bakedCount;
                            break;
                        case "cakes":
                            raisedMoney += 1.0 * bakedCount * 7.80;
                            cakesCount += bakedCount;
                            break;
                        case "waffles":
                            raisedMoney += 1.0 * bakedCount * 2.30;
                            wafflesCount += bakedCount;
                            break;
                    }

                    baking = Console.ReadLine();
                }

                Console.WriteLine($"{competitorName} baked {cookiesCount} cookies, {cakesCount} cakes and {wafflesCount} waffles.");

                cookiesCount = 0;
                cakesCount = 0;
                wafflesCount = 0;

            }

            Console.WriteLine($"All bakery sold: {bakingCount}");
            Console.WriteLine($"Total sum for charity: {raisedMoney:f2} lv.");
        }
    }
}
