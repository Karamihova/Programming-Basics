using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int minValue = int.MaxValue;
            int maxValue = int.MinValue;

            for (int i = 0; i < count; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (currentNum > maxValue)
                {
                    maxValue = currentNum;
                }
                if (currentNum < minValue)
                {
                    minValue = currentNum;
                }
            }

            Console.WriteLine($"Max number: {maxValue}");
            Console.WriteLine($"Min number: {minValue}");
        }
    }
}
