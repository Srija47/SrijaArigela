using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Delivery d = new Delivery();
            string bowler;
            string batsman;
            Console.WriteLine("Menu\n");
            Console.WriteLine("1.Player Details of the Delivery\n 2.Run Details of the Delivery\n");
            Console.WriteLine("Enter choice\t");
            int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    Console.WriteLine("Player Details of the Delivery\n");
                    Console.WriteLine("Enter Name of the Bowler\n");
                    bowler = Console.ReadLine();
                    Console.WriteLine("Enter Name of the Batsman\n");
                    batsman = Console.ReadLine();
                    d.DisplayDeliveryDetails(bowler, batsman);
                    break;
                case 2:
                    Console.WriteLine("Run Details of the Delivery\n");
                    int runs = int.Parse(Console.ReadLine());
                    d.DisplayDeliveryDetails(runs);
                    break;
                default:
                    Console.WriteLine("Invalid Choice\n");
                    break;
            }
            Console.ReadLine();
        }
    }
}
