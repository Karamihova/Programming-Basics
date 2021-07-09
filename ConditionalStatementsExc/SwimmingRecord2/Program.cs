using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingRecord2
{
    class Program
    {
        static void Main(string[] args)
        {

            //input

            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secPerMeter = double.Parse(Console.ReadLine());

            //calc

            double swimmerTime = distance * secPerMeter;
            double obstacle = (Math.Floor(distance / 15)) * 12.5;
            double swimmerRecord = swimmerTime + obstacle;


            //print

            if (record>swimmerRecord)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {swimmerRecord:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {swimmerRecord-record:f2} seconds slower.");
            }
        }
    }
}
