using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int minNum = int.MaxValue;

            while (count < n)
            {
                int currNum = int.Parse(Console.ReadLine());
                if (currNum < minNum)
                {
                    minNum = currNum;
                }

                count++;
            }

            Console.WriteLine(minNum);
        }
    }
}
