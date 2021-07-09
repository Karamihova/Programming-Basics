using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            string type = "";

            for (int rows = floors; rows >= 1; rows--)
            {
                for (int col = 0; col < rooms; col++)
                {
                    if (rows == floors)
                    {
                        type = "L";
                    }
                    else
                    {
                        if (rows % 2 == 0)
                        {
                            type = "O";
                        }
                        else
                        {
                            type = "A";
                        }
                    }

                    Console.Write($"{type}{rows}{col} ");

                }
                Console.WriteLine();
            }
        }
    }
}
