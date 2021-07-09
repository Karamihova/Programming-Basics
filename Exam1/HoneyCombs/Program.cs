using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoneyCombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int beesCount = int.Parse(Console.ReadLine());
            int flowersCount = int.Parse(Console.ReadLine());

            double totalHoney = 1.0 * beesCount * flowersCount * 0.21;
            double honeyCombs = totalHoney / 100;
            double leftHoney = totalHoney % 100;

            Console.WriteLine($"{Math.Floor(honeyCombs)} honeycombs filled.");
            Console.WriteLine($"{leftHoney:f2} grams of honey left.");
        }
    }
}
