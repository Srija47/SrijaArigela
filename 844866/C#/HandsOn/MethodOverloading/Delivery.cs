using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Delivery
    {
        public virtual void DisplayDeliveryDetails(string bowler,string batsman)
        {
            Console.WriteLine("Name of the Bowler "+ bowler+"\nName of Batsman "+  batsman);
        }
        public void DisplayDeliveryDetails(int runs)
        {
            if (runs == 6)
                Console.WriteLine("Six" + runs);
            else if (runs == 4)
                Console.WriteLine("Four" + runs);
            else
                Console.WriteLine(runs);
        }
    }
}
