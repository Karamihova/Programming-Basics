using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterStockedHoney
{
    class Program
    {
        static void Main(string[] args)
        {
            double honeyNeeded = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            double acquiredHoneyPerBee = 0.0;
            double totalHoney = 0.0;
            bool isEnough = false;
            while (input != "Winter has come")
            {
                string beeName = input;
                for (int month = 1; month <= 6; month++)
                {
                    double acquiredHoney = double.Parse(Console.ReadLine());
                    acquiredHoneyPerBee += acquiredHoney;
                    

                }

                if (acquiredHoneyPerBee < 0)
                {
                    Console.WriteLine($"{beeName} was banished for gluttony");
                   
                }

                totalHoney += acquiredHoneyPerBee;
                acquiredHoneyPerBee = 0;
                input = Console.ReadLine();

                if (totalHoney >= honeyNeeded)
                {
                    isEnough = true;
                    break;
                    
                }
            }

            if (isEnough)
            {
                Console.WriteLine($"Well done! Honey surplus {(totalHoney - honeyNeeded):f2}.");
            }
            else
            {
                Console.WriteLine($"Hard Winter! Honey needed {(honeyNeeded - totalHoney):f2}.");
            }

        }
    }
}
