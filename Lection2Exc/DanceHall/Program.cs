using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanceHall
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            double hallLength = double.Parse(Console.ReadLine());
            double hallWidth = double.Parse(Console.ReadLine());
            double wardrobeMeters = double.Parse(Console.ReadLine());


            //calculate
            double hallArea = (hallLength * 100) * (hallWidth * 100);
            double wardrobeArea = (wardrobeMeters * 100) * (wardrobeMeters * 100);
            double bench = hallArea / 10;

            double enoughSpace = hallArea - wardrobeArea - bench;
            double dancers = enoughSpace / (40 + 7000);

            //print
            Console.WriteLine(Math.Floor(dancers));


        }
    }
}
