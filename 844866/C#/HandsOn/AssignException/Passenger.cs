using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignException
{
    public class TicketException : Exception
    {

        public TicketException(string s) : base(s)
        {

        }
    }
    public class Passenger
    {
        string name;
        int age;
        public Passenger(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public void TicketBooking(int nooftickets)
        {

            try
            {
                if (nooftickets > 2)
                    throw new TicketException("Cannot book more than 2");
                else
                    Console.WriteLine("Ticket Booked Successfully");
            }
            catch (TicketException e)
            {
                Console.WriteLine(e.Message + " " + e.StackTrace);
            }
        }

    }
    
}

