using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double evenSum = 0.00;
            double oddSum = 0.00;
            double evenMax = double.MinValue;
            double oddMax = double.MinValue;
            double evenMin = double.MaxValue;
            double oddMin = double.MaxValue;

            for (int i = 1; i <= count; i++)
            {
                double currentNum = double.Parse(Console.ReadLine());

                if (i % 2 ==0)
                {
                    evenSum += currentNum;
                    if (currentNum > evenMax)
                    {
                        evenMax = currentNum;
                    }

                    if (currentNum < evenMin)
                    {
                        evenMin = currentNum;
                    }
                }
                else
                {
                    oddSum += currentNum;
                    if (currentNum > oddMax)
                    {
                        oddMax = currentNum;
                    }

                    if (currentNum< oddMin)
                    {
                        oddMin = currentNum;
                    }
                }
            }
            if (evenSum == 0.00 && oddSum == 0.00)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else if(oddSum == 0.00)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
            else if (evenSum == 0.00)
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:f2},");
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
                Console.WriteLine($"EvenSum={evenSum:f2},");
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
            



        }
    }
}
