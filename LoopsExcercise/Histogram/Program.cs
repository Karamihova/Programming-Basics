using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int number = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            int sum5 = 0;
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;
            double p4 = 0.0;
            double p5 = 0.0;

            for (int i = 0; i < count; i++)
            {
                number = int.Parse(Console.ReadLine());

                if (number < 200)
                {
                    sum1++;
                }
                else if (number >= 200 && number <= 399)
                {
                    sum2++;

                }
                else if (number >= 400 && number <= 599)
                {
                    sum3++;

                }
                else if (number >= 600 && number <= 799)
                {
                    sum4++;

                }
                else
                {
                    sum5++;

                }
            }


            p1 = sum1 * 1.0 / count * 100.0;
            p2 = sum2 * 1.0 / count * 100.0;
            p3 = sum3 * 1.0 / count * 100.0;
            p4 = sum4 * 1.0 / count * 100.0;
            p5 = sum5 * 1.0 / count * 100.0;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");



        }
    }
}
