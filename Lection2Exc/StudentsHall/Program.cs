using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            double skumriaLvPerKg = double.Parse(Console.ReadLine());
            double tsatsaLvPerKg = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            int midiKg = int.Parse(Console.ReadLine());

            //calc
            double palamud = palamudKg*(skumriaLvPerKg + (0.6*skumriaLvPerKg));
            double safrid = safridKg*(tsatsaLvPerKg + (0.8*tsatsaLvPerKg));
            double midi = midiKg * 7.5;
            double totalSum = palamud + safrid + midi;

            //print
            Console.WriteLine(Math.Round(totalSum,2,MidpointRounding.AwayFromZero));
        }
    }
}
