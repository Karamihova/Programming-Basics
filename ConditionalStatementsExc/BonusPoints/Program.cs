﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double bonus = 0.0;
            


            if (number <= 100)
            {
                bonus = 5;
            }
            else if (number > 1000)
            {
                bonus = number * 0.1;
            }
            else 
            {
                bonus = number * 0.2;
            }

            if (number%2 == 0 )
            {
                bonus = bonus + 1;
            }
            else if (number%10 == 5)
            {
                bonus = bonus + 2;
            }

            
            double allPoints = number + bonus;

            Console.WriteLine(bonus);
            Console.WriteLine(allPoints);
        }
    }
}
