using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            int totaltickets = 0;
            int studentTickets = 0;
            int standardTickets = 0;
            int kidsTickets = 0;
            while (true)
            {
                string movie = Console.ReadLine();
                if (movie == "Finish")
                {
                    break;
                }

                int capacity = int.Parse(Console.ReadLine());
                int movieTickets = 0;

                while (true)
                {
                    string ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }

                    switch (ticketType)
                    {
                        case "student":
                            studentTickets++;
                            break;
                        case "standard":
                            standardTickets++;
                            break;
                        case "kid":
                            kidsTickets++;
                            break;
                        default:
                            break;
                    }
                    movieTickets++;
                    if (movieTickets >= capacity)
                    {
                        break;
                    }
                }

                Console.WriteLine($"{movie} - {100.0 * movieTickets / capacity:f2}% full.");
                totaltickets += movieTickets;
            }

            Console.WriteLine($"Total tickets: {totaltickets}");
            Console.WriteLine($"{100.0 *studentTickets / totaltickets:f2}% student tickets.");
            Console.WriteLine($"{100.0 * standardTickets / totaltickets:f2}% standard tickets.");
            Console.WriteLine($"{100.0 * kidsTickets / totaltickets:f2}% kids tickets.");
        }
    }
}
