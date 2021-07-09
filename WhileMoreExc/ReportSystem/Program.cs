using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            //read
            int neededMoney = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int raisedMoney = 0;
            int countPay = 1;
            int withCashCount = 0;
            int withCardCount = 0;
            int cashMoney = 0;
            int cardMoney = 0;
            //calc
            while (input != "End")
            {
                int productPrice = int.Parse(input);
                if (countPay % 2 == 0)
                {
                    //with card
                    if (productPrice < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        cardMoney += productPrice;
                        raisedMoney += productPrice;
                        withCardCount++;
                    }
                }
                else
                {
                    //in cash
                    if (productPrice > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        cashMoney += productPrice;
                        raisedMoney += productPrice;
                        withCashCount++;
                    }
                }
                if (raisedMoney >= neededMoney)
                {
                    break;
                }

                countPay++;
                input = Console.ReadLine();
            }
            //print
            if (raisedMoney >= neededMoney)
            {
                double averageCash = 1.0 * cashMoney / withCashCount;
                double averageCard = 1.0 * cardMoney / withCardCount;
                Console.WriteLine($"Average CS: {averageCash:f2}");
                Console.WriteLine($"Average CC: {averageCard:f2}");
            }
            else
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
