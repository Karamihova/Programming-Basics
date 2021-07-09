using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double number = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            //calc
            if (input == "m" )
            {
                if (output == "cm")
                {
                    number = number * 100;
                }
                else
                {
                    number = number * 1000;
                }
            }
            else if (input == "cm")
            {
                if (output== "m")
                {
                    number = number / 100;
                }
                else
                {
                    number = number *10;
                }
            }
            else
            {
                if (output == "cm")
                {
                    number = number * 0.1;
                }
                else
                {
                    number = number * 0.001;
                }
            }

            //print
            Console.WriteLine($"{number:F3}");
        }
    }
}
