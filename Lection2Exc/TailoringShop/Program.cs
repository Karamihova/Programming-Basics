using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TailoringShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            int tablesNum = int.Parse(Console.ReadLine());
            double tablesLength = double.Parse(Console.ReadLine());
            double tablesWidth = double.Parse(Console.ReadLine());

            //calculate

            double tableClothAsrea = tablesNum * (tablesLength + 2 * 0.30) * (tablesWidth + 2 * 0.30);
            double tableSquareArea = tablesNum * (tablesLength / 2) * (tablesLength / 2);

            double dolarPrice = tableClothAsrea * 7 + tableSquareArea * 9;
            double levaPrice = dolarPrice * 1.85;

            //print
            Console.WriteLine($"{dolarPrice:F2} USD");
            Console.WriteLine($"{levaPrice:F2} BGN");
        }
    }
}
