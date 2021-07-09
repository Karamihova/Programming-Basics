using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehivePopulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int population = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());

            int currPopulation = population;
            for (int currYear = 1; currYear <= years; currYear++)
            {
                if (currYear % 5 == 0)
                {
                    int births = currPopulation / 10 * 2;
                    currPopulation += births;
                    int migrated = currPopulation / 50 * 5;
                    currPopulation -= migrated;
                    int deaths = currPopulation / 20 * 2;
                    currPopulation -= deaths;
                }
                else
                {
                    int births = currPopulation / 10 * 2;
                    currPopulation += births;
                    int deaths = currPopulation / 20 * 2;
                    currPopulation -= deaths;
                }
                
            }

            Console.WriteLine($"Beehive population: {currPopulation}");
        }
    }
}
