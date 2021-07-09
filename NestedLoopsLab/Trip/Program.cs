﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string destination = Console.ReadLine();
                if (destination == "End")
                {
                    break;
                }

                double budget = double.Parse(Console.ReadLine());

                while (budget > 0)
                {
                    double currMoney = double.Parse(Console.ReadLine());
                    budget -= currMoney;
                }

                Console.WriteLine($"Going to {destination}!");
            }

        }
    }
}
