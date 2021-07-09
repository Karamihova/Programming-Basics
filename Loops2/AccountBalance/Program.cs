using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int payCount = int.Parse(Console.ReadLine());
            int n = 0;
            double total = 0.0;
            double currentPay = 0.0;

            while (n < payCount)
            {
                currentPay = double.Parse(Console.ReadLine());
                if (currentPay >= 0)
                {
                    Console.WriteLine($"Increase: {currentPay:f2}");
                    total += currentPay;
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                n++;
            }

            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
