using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDeligate2
{
    class Program
    {
       // public delegate double calAreaPointer(double x);
        static void Main(string[] args)
        {
            //calAreaPointer cptr = new calAreaPointer(calArea);

            //anonymous method
            //calAreaPointer cptr = new calAreaPointer(delegate (double r) { return 3.14 * r * r; });
            //above code can si,plify with lambda
            //calAreaPointer cptr1 = (r => 3.14 * r * r);
            //double area1 = cptr(10);
            //double area = cptr(12);
            //Console.WriteLine(area1);
            //Console.WriteLine(area);
            //prebuild delegates Func<>,Action<>,Predicate<>
            //Func delegate can have input and output parameter
            Func<double, double> f1 = (r => 3.14 * r * r);
            double area2 = f1(14);
            Console.WriteLine(area2);
            Action<string> act = (x => Console.WriteLine(x));
            act("welcome");
            Predicate<string> pt = (y => y.Length > 3);
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            List<string> names = new List<string>();
            names.Add("Ajay");
            names.Add("Rana");
            names.Add("Ravi");
            int x1 = array.Count(x => x > 2);
            Console.WriteLine(x1);
            List<string> sn = names.FindAll(y => y.Contains('y'));

            foreach(string n in sn)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine(pt("ctsytr"));
            Console.ReadLine();
        }
        /*
        public static double calArea(double r)
        {
            return 3.14 * r * r;
        }
        */
    }
}
