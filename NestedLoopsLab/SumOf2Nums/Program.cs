using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOf2Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            //read
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            //calc
            int combinations = 0;
            bool isFound = false;
            int x = 0;
            int y = 0;

            for (int num1 = start; num1 <= end; num1++)
            {
                for (int num2 = start; num2 <= end ; num2++)
                {
                    combinations++;

                    if (num1 + num2 == magicNum)
                    {
                        x = num1;
                        y = num2;
                        isFound = true;
                        break;
                    }
                }

                if (isFound)
                {
                    break;
                }

            }

            //print
            if (isFound)
            {
                Console.WriteLine($"Combination N:{combinations} ({x} + {y} = {magicNum})");
            }
            else
            {
                Console.WriteLine($"{combinations} combinations - neither equals {magicNum}");
            }
        }
    }
}
