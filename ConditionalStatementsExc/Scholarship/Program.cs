using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minWorkingSalary = double.Parse(Console.ReadLine());



            //calc

            double socialScholarship = minWorkingSalary * 0.35;
            double excScholarship = averageSuccess*25;

            //print

            if (income<minWorkingSalary && averageSuccess>4.5)
            {
                if (averageSuccess>=5.5)
                {
                    if (socialScholarship>excScholarship)
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                    }
                    else if (socialScholarship == excScholarship)
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excScholarship)} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excScholarship)} BGN");

                    }
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                }
            }
            else if (averageSuccess >= 5.5)
            {
                        Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excScholarship)} BGN");

            }
            else
            {
                Console.WriteLine($"You cannot get a scholarship!");
            }

        }
    }
}
