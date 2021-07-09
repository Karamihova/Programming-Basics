using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string bookTitle = Console.ReadLine();
            int libraryCapaciy = int.Parse(Console.ReadLine());

            bool isFound = false;
            int checkedBooks = 0;
            while (!isFound)
            {
                string currBook = Console.ReadLine();
                if (currBook == bookTitle)
                {
                    isFound = true;
                }
                else
                {
                     checkedBooks++;
                    if (checkedBooks >= libraryCapaciy)
                    {
                        break;
                    }
                }
            }

            if (isFound)
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
