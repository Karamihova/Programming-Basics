using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double a, b, area;

            if (figure == "square")
            {
                a = double.Parse(Console.ReadLine());
                area = a * a;
                Console.WriteLine($"{area:F3}");
            }
            else if(figure == "rectangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                area = a * b;
                Console.WriteLine($"{area:F3}");

            }
            else if (figure == "circle")
            {
                a = double.Parse(Console.ReadLine());
                area = Math.PI * (a*a);
                Console.WriteLine($"{area:F3}");
            }
            else if (figure == "triangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                area = a * b / 2;
                Console.WriteLine($"{area:F3}");

            }



        }
    }
}
