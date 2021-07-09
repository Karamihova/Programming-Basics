using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            //input

            //съпротивлението на водата го забавя на всеки 15 м.с 12.5 секунди.
            //Когато се изчислява колко пъти Иванчо ще се забави, в резултат на съпротивлението на водата, 
            //резултатът трябва да се закръгли надолу до най - близкото цяло число.
            //Да се изчисли времето в секунди, за което Иванчо ще преплува разстоянието и разликата спрямо Световния рекорд. 

            double recordInSec = double.Parse(Console.ReadLine());
            double distanceInM = double.Parse(Console.ReadLine());
            double timeSwimSecPerMeter = double.Parse(Console.ReadLine());



            //calc

            double distanceTime = distanceInM * timeSwimSecPerMeter;
            double hindrance = (distanceInM / 15) * 12.5;
            double swimmerTime = distanceTime + Math.Round(hindrance,MidpointRounding.AwayFromZero);

            //print

            if (recordInSec<swimmerTime)
            {
                Console.WriteLine($"No, he failed! He was {swimmerTime-recordInSec:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {swimmerTime:f2} seconds.");
            }


        }
    }
}
