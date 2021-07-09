using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = Console.ReadLine();

            string currPassword = Console.ReadLine();
            while (currPassword != password)
            {
                currPassword = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {userName}!");
        }
    }
}
