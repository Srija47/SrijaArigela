using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignException
{
    class Program
    {
        static void Main(string[] args)
        {
            Passenger p = new Passenger("srija",23);
            Console.WriteLine("Enter no of tickets:");
            int nooftickets = int.Parse(Console.ReadLine());
            p.TicketBooking(nooftickets);
            Console.ReadKey();
        }
    }
}
