using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookTitle = Console.ReadLine();
            bool isBookFound = false;
            int booksCount = int.Parse(Console.ReadLine());
            int checkedBooks = 0;

            while (!isBookFound)
            {
                string currBook = Console.ReadLine();

                if (currBook == bookTitle)
                {
                    isBookFound = true;
                    break;
                }
                else
                {
                    checkedBooks++;
                    if (checkedBooks >= booksCount)
                    {
                        break;
                    }
                }
            }

            if (isBookFound)
            {
                Console.WriteLine($"You checked {checkedBooks} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks} books.");
            }

        }
    }
}
