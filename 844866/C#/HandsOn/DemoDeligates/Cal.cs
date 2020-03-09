using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDeligates
{
    class Cal
    {
        public static double calArea(double r)
        {
            Console.WriteLine("Calculate Area");
            return 3.14 * r*r ;
        }
        public static double caldist(double d)
        {
            return d * 100;
        }
    }
}
