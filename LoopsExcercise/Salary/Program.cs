using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabsCount = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            int fee = 0;

            for (int i = 0; i < tabsCount; i++)
            {
                string website = Console.ReadLine();

                if (website == "Facebook")
                {
                    fee += 150;
                    salary -= fee;
                }
                if (website == "Instagram")
                {
                    fee += 100;
                    salary -= fee;
                }
                if (website == "Reddit")
                {
                    fee += 50;
                    salary -= fee;
                }

                if (salary <= 0)
                {
                    break;
                }

                fee = 0;

            }

            
            if (salary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            if (salary > 0)
            {
                Console.WriteLine($"{salary}");
            }
            
        }
    }
}
