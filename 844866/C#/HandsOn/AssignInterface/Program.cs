using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Dayscholar for D/d orResident for R/r\n");
            string type = Console.ReadLine();
            if (type == "D" || type == "d")
            {
                
                Console.WriteLine("Enter Student Details");
                Console.WriteLine("Enter Student ID :\t");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student Name :\t");
                string name = Console.ReadLine();
                DayScholar d = new DayScholar(id, name);
                d.ShowDetails(id, name);
            }
            else if (type == "R" || type == "r")
            {
                
                Console.WriteLine("Enter Student Details");
                Console.WriteLine("Enter Student ID :\t");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Student Name :\t");
                string name = Console.ReadLine();
                Resident r = new Resident(id, name);
                r.ShowDetails(id, name);
            }
            else
            {
                Console.WriteLine("Invalid Inputs\n");
            }
            
            
            Console.ReadKey();
        }
    }
}
