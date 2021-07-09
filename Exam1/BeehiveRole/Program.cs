using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveRole
{
    class Program
    {
        static void Main(string[] args)
        {
            int intelligence = int.Parse(Console.ReadLine());
            int strength = int.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (intelligence >= 80)
            {
                if (strength >= 80 && gender == "female")
                {
                    Console.WriteLine("Queen Bee");
                }
                else
                {
                    Console.WriteLine("Repairing Bee");
                }
            }
            else if ( intelligence >= 60)
            {
                Console.WriteLine("Cleaning Bee");
            }
            else
            {
                if (strength >= 80 && gender == "male")
                {
                    Console.WriteLine("Drone Bee");
                }
                else if (strength >= 60)
                {
                    Console.WriteLine("Guard Bee");
                }
                else
                {
                    Console.WriteLine("Worker Bee");
                }
            }
        }
    }
}
