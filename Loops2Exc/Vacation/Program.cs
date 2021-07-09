using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyForVac = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());

            int days = 0;
            int spentDays = 0;
            while (currentMoney < moneyForVac && spentDays < 5)
            {
                string action = Console.ReadLine();
                double spentOrSavedMoney = double.Parse(Console.ReadLine());

                if (action == "save")
                {
                    currentMoney += spentOrSavedMoney;
                    spentDays = 0;
                }

                if(action == "spend")
                {
                    currentMoney -= spentOrSavedMoney;
                    if (spentOrSavedMoney > currentMoney)
                    {
                        currentMoney = 0;
                    }
                    spentDays++;
                }

                days++;
            }

            if (spentDays == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{days}");
            }
            if( currentMoney >= moneyForVac)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
