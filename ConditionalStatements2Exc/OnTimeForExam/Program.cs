using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());


            //calc exam: 09:20      arrival: 09:10

            examMin = examMin + (examHour * 60);
            arrivalMin = arrivalMin + (arrivalHour * 60);

            
            // late > exam time
            if (arrivalMin > examMin)
            {
                Console.WriteLine("Late");
                int difference = arrivalMin - examMin;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    int h = difference / 60;
                    int m = difference % 60;
                    Console.WriteLine($"{h}:{m:d2} hours after the start");
                }
            }
            // early
            else if (arrivalMin < examMin - 30)
            {
                Console.WriteLine("Early");
                int difference = examMin - arrivalMin;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    int h = difference / 60;
                    int m = difference % 60;
                    Console.WriteLine($"{h}:{m:d2} hours before the start");
                }
            }
            // on time 
            else
            {
                Console.WriteLine("On time");
                int difference = examMin - arrivalMin;
                Console.WriteLine($"{difference} minutes before the start");
            }

            //print
        }
    }
}
