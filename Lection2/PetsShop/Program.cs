using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsCount = int.Parse(Console.ReadLine());
            int otherAnimalsCount = int.Parse(Console.ReadLine());

            double dogsExpenses = dogsCount * 2.50;
            double otherAnimalsExpenses = otherAnimalsCount * 4;
            double totalSum = dogsExpenses + otherAnimalsExpenses;

            Console.WriteLine($"{totalSum:f2} lv.");
        }
    }
}
