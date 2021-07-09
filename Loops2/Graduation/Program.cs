using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int schoolYear = 1;
            double yearGrade = 0.0;
            double sum = 0.0;
            double diplomaGrade = 0.0;
            int n = 1;

            while (schoolYear <=12)
            {
                yearGrade = double.Parse(Console.ReadLine());
                if (yearGrade >= 4)
                {
                    sum += yearGrade;
                    schoolYear++;
                }
                else
                {
                    if (n == 1)
                    {
                        yearGrade = double.Parse(Console.ReadLine());
                        if (yearGrade >=4)
                        {
                            sum += yearGrade;
                            schoolYear++;
                        }
                        else
                        {
                            n++;
                            Console.WriteLine($"{studentName} has been excluded at {schoolYear} grade");
                            break;
                        }
                    }
                }
            }

            if (n == 1)
            {
                diplomaGrade = sum / 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {diplomaGrade:f2}");
            }
           
        }
    }
}
