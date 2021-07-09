using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int widht = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int totalSize = widht * lenght;
            int currentPieces = 0;
            string pieces = Console.ReadLine();
            while (currentPieces <= totalSize && pieces != "STOP")
            {
                currentPieces = currentPieces + int.Parse(pieces);
                if (currentPieces >= totalSize)
                {
                    Console.WriteLine($"No more cake left! You need {currentPieces - totalSize} pieces more.");
                    break;
                }
                pieces = Console.ReadLine();

                if (pieces == "STOP")
                {
                    Console.WriteLine($"{totalSize - currentPieces} pieces are left.");
                    break;
                }

            }

        }
    }
}