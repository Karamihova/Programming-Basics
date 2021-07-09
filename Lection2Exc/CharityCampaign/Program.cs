using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int daysCount = int.Parse(Console.ReadLine());
            int bakersCount = int.Parse(Console.ReadLine());
            int cakesCount = int.Parse(Console.ReadLine());
            int goufretesCount = int.Parse(Console.ReadLine());
            int pancakesCount = int.Parse(Console.ReadLine());

            //calculate

            double totalMoney = daysCount * (bakersCount*((cakesCount*45)+(goufretesCount*5.80)+(pancakesCount*3.20)));
            double charityMoney = totalMoney- (totalMoney /8);

            //print
            Console.WriteLine($"{charityMoney:F2}");
        }
    }
}
