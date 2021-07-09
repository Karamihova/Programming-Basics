using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time15
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            

            if (minutes >= 45 && hour < 23) // 22:45 -> 23:00
            {
                minutes = (minutes + 15)-60;
                hour = hour + 1;
            }
            else if (minutes >= 45 && hour==23) // 23:45 -> 0:00
            {
                minutes = (minutes + 15) - 60;
                hour = 0;
            }
            else // 20:35 -> 20:50
            {
                minutes = minutes + 15;
            }

            Console.WriteLine($"{hour}:{minutes:d2}");
        }
    }
}
