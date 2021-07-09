using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {                                                   // 3 is prime -> / 1 && 3
            string input = Console.ReadLine();

            int primeSum = 0;
            int nonPrimeSum = 0;
            while (input != "stop")
            {
                int counter = 0;
                int currNum = int.Parse(input);

                if (currNum < 0)
                {
                    Console.WriteLine($"Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                for (int i = 2; i <= currNum; i++)
                {
                    if (currNum % i == 0)
                    {
                        counter++;
                    }
                    
                }

                if (counter == 1)
                {
                    primeSum += currNum;
                }
                else
                {
                    nonPrimeSum += currNum;
                }
                
                input = Console.ReadLine();

            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
