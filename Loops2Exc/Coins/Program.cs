using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            int cents = (int)(change * 100);
            int coinsCount = 0;
            while (cents > 0)
            {
                if (cents - 200 >= 0)
                {
                    cents -= 200;
                    coinsCount++;
                }
                else if (cents - 100 >= 0)
                {
                    cents -= 100;
                    coinsCount++;
                }
                else if (cents - 50 >= 0)
                {
                    cents -= 50;
                    coinsCount++;
                }
                else if (cents - 20 >= 0)
                {
                    cents -= 20;
                    coinsCount++;
                }
                else if (cents - 10 >= 0)
                {
                    cents -= 10;
                    coinsCount++;
                }
                else if (cents - 5 >= 0)
                {
                    cents -= 5;
                    coinsCount++;
                }
                else if (cents - 2 >= 0)
                {
                    cents -= 2;
                    coinsCount++;
                }
                else if (cents - 1 >= 0)
                {
                    cents -= 1;
                    coinsCount++;
                }
            }

            Console.WriteLine(coinsCount);

        }
    }
}
