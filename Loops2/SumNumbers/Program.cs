using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //read int num while command = Stop then print the summed nums

            string input = Console.ReadLine();
            int sum = 0;

            while (input != "Stop")
            {
                int currNum = int.Parse(input);
                sum += currNum;
                input = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }
    }
}
