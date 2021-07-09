using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            //read input
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            //calculate
            int volume = length * width * height;
            double liters = volume * 0.001;
            double sand = liters * percent / 100;
            double remaining = liters - sand;

            //print
            Console.WriteLine($"{remaining:F3}");
        }
    }
}
