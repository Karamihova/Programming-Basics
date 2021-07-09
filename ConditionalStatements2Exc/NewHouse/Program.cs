using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0.0;
            double discount = 0.0;

            //calc

            switch (flowerType)
            {
                case "Roses": price = flowerCount * 5;
                    if (flowerCount > 80)
                    {
                        discount = price * 0.1;
                        price = price - discount;
                    }
                    break;
                case "Dahlias": price = flowerCount * 3.80;
                    if (flowerCount > 90)
                    {
                        discount = price * 0.15;
                        price = price - discount;

                    }
                    break;
                case "Tulips": price = flowerCount * 2.80;
                    if (flowerCount > 80)
                    {
                        discount = price * 0.15;
                        price = price - discount;

                    }
                    break;
                case "Narcissus": price = flowerCount * 3;
                    if (flowerCount < 120)
                    {
                        price = price + (price * 0.15);
                    }
                    break;
                case "Gladiolus": price = flowerCount * 2.50;
                    if (flowerCount < 80)
                    {
                        price = price + (price * 0.2);

                    }
                    break;
            }

            //print

            if ( price <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");
            }
        }
    }
}
