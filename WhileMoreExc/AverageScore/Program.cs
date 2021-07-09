using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double sum = 0;

            for (int i = 0; i < count; i++)
            {
                int currScore = int.Parse(Console.ReadLine());
                sum += currScore;
            }

            Console.WriteLine($"{sum / count:f2}");
        }
    }
}
