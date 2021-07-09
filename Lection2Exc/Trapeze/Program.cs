using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapeze
{
    class Program
    {
        static void Main(string[] args)
        {
            ////input
            //double b1 = double.Parse(Console.ReadLine());
            //double b2 = double.Parse(Console.ReadLine());
            //double h = double.Parse(Console.ReadLine());

            ////calc
            //double trapezeArea = (b1 + b2) * h / 2;

            ////print
            //Console.WriteLine($"{trapezeArea:F2}");

            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area =  a * h / 2;
            Console.WriteLine($"{area:F2}");
        }
    }
}
