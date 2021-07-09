using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int firstGroup = 0;
            int secondGroup = 0;
            int thirdGroup = 0;

            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;

            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    firstGroup++;
                }
                if (number % 3 == 0)
                {
                    secondGroup++;
                }
                if (number % 4 == 0)
                {
                    thirdGroup++;
                }
            }

            p1 = (firstGroup * 1.0 / count) * 100.0;
            p2 = (secondGroup * 1.0 / count) * 100.0;
            p3 = (thirdGroup * 1.0 / count) * 100.0;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");

        }
    }
}
