﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectsProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int numberOfProjects = int.Parse(Console.ReadLine());

            double sumTime = numberOfProjects * 3;

            Console.WriteLine($"The architect {architectName} will need {sumTime} hours to complete {numberOfProjects} project/s.");
        }
    }
}
