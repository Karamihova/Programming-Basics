using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumsN1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                for (int i = num; i >= 1; i--)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
