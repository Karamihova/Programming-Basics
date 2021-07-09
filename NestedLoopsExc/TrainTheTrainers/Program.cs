using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            //read
            int jury = int.Parse(Console.ReadLine());
            string presentationTitle = Console.ReadLine();
            int markCount = 0;
            double sumMarksPerPresent = 0.0;
            double sumAverageMarks = 0.0;
            int presenationCount = 0;

            while (presentationTitle != "Finish")
            {
                for (int i = 1; i <= jury; i++)
                {
                   double mark = double.Parse(Console.ReadLine());
                   sumMarksPerPresent += mark;
                   markCount++;
                    if (i >= jury)
                    {
                        double averageMarkPerPresent = sumMarksPerPresent / markCount;
                        Console.WriteLine($"{presentationTitle} - {averageMarkPerPresent:f2}.");
                        sumAverageMarks += averageMarkPerPresent;
                        break;
                    }

                }
                sumMarksPerPresent = 0;
                markCount = 0;
                presenationCount++;
                presentationTitle = Console.ReadLine();
            }
            double averageScore = sumAverageMarks / presenationCount;
            Console.WriteLine($"Student's final assessment is {averageScore:f2}.");
        }
    }
}
