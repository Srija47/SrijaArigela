using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Year = 2019;
            c[0] = "Maruthi";
            c[1] = "Benz";
            c[2] = "Honda";
            c.display();
            //string[] ar = new string[] { "Maruthi","Benz"};
            Console.WriteLine(c[0]);
            Console.ReadKey();
        }
    }
}
