using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            //read
            int widthSpace = int.Parse(Console.ReadLine());
            int lengthSpace = int.Parse(Console.ReadLine());
            int heightSpace = int.Parse(Console.ReadLine());

            int freeSpace = widthSpace * lengthSpace * heightSpace;

            string command = Console.ReadLine();
            int boxesSpace = 0;
            while (command != "Done")
            {
                int currBox = int.Parse(command);
                boxesSpace += currBox;
                if (freeSpace < boxesSpace)
                {
                    Console.WriteLine($"No more free space! You need {boxesSpace - freeSpace} Cubic meters more.");
                    break;
                }

                command = Console.ReadLine();

            }

            if (freeSpace >= boxesSpace)
            {
                Console.WriteLine($"{freeSpace - boxesSpace} Cubic meters left.");
            }
        }
    }
}
