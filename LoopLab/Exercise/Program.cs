using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = Console.ReadLine();

            //for (int i = 0; i < text.Length; i++)
            //{
            //    Console.WriteLine(text[i]);
            //}

            string text = Console.ReadLine();
            int sum = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    sum += 1;
                }
                if (text[i] == 'e')
                {
                    sum += 2;
                }
                if (text[i] == 'i')
                {
                    sum += 3;
                }
                if (text[i] == 'o')
                {
                    sum += 4;
                }
                if (text[i] == 'u')
                {
                    sum += 5;
                }

                
            }

            Console.WriteLine(sum);
        }
    }
}
