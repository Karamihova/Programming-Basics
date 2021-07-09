using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int maxNum = int.MinValue;

            while (count < n)
            {
                int currNum = int.Parse(Console.ReadLine());
                if (currNum > maxNum)
                {
                    maxNum = currNum;
                }

                count++;
            }

            Console.WriteLine(maxNum);
        }
    }
}
