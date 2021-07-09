using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorMarkCount = int.Parse(Console.ReadLine());

            bool isFailed = true;
            double problemSum = 0.0;
            int problemCount = 0;
            int failedTimes = 0;
            string lastProblem = "";

            while (failedTimes < poorMarkCount)
            {
                string problemName = Console.ReadLine();

                if (problemName == "Enough")
                {
                    isFailed = false;
                    break;
                }
                else
                {
                    lastProblem = problemName;
                }

                int problemMark = int.Parse(Console.ReadLine());

                if (problemMark <= 4)
                {
                    failedTimes++;
                    if (failedTimes >= poorMarkCount)
                    {
                        isFailed = true;
                        break;
                    }
                }

                problemSum += problemMark;
                problemCount++;

            }

            if (isFailed)
            {
                Console.WriteLine($"You need a break, {failedTimes} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {problemSum / problemCount:f2}");
                Console.WriteLine($"Number of problems: {problemCount}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }

        }
    }
}
