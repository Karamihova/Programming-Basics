using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidOfNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int targetNum = int.Parse(Console.ReadLine());
            int rows = 1;
            int currNum = 1;
            bool isReached = false;

            while (!isReached)
            {
                for (int col = 1; col <= rows; col++)
                {
                    Console.Write(currNum + " ");
                    currNum++;
                    if (currNum > targetNum)
                    {
                        isReached = true;
                        break;
                    }
                }
                rows++;
                Console.WriteLine();
            }
        }
    }
}
