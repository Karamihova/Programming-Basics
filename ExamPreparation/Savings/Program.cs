using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savings
{
    class Program
    {
        static void Main(string[] args)
        {
            //read
            double incomePerMonth = double.Parse(Console.ReadLine());
            int monthCount = int.Parse(Console.ReadLine());
            double personalExpenses = double.Parse(Console.ReadLine());

            //count
            double moneyForUnpredictedSit = 0.3 * incomePerMonth;
            double savedMoneyPerMonth = incomePerMonth - (personalExpenses + moneyForUnpredictedSit);
            double totalSavedMoney = savedMoneyPerMonth * monthCount;
            double percentSavedMoney = savedMoneyPerMonth / incomePerMonth * 100.0;

            //print
            Console.WriteLine($"She can save {percentSavedMoney:f2}%");
            Console.WriteLine($"{totalSavedMoney:f2}");
        }
    }
}
