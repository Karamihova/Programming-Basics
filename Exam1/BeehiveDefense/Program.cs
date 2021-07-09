using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveDefense
{
    class Program
    {
        static void Main(string[] args)
        {
            int bees = int.Parse(Console.ReadLine());
            int bearHealth = int.Parse(Console.ReadLine());
            int bearAttack = int.Parse(Console.ReadLine());

            bool didBearWon = false;
            while (true)
            {
                bees = bees - bearAttack;
                bearHealth = bearHealth - (bees * 5);

                if (bees < 100)
                {
                    didBearWon = true;
                    if (bees < 0)
                    {
                        bees = 0;
                    }
                    break;
                }
                else if (bearHealth <= 0)
                {
                    break;
                }
            }

            if (didBearWon)
            {
                Console.WriteLine($"The bear stole the honey! Bees left {bees}.");
            }
            else
            {
                Console.WriteLine($"Beehive won! Bees left {bees}.");
            }
        }
    }
}
