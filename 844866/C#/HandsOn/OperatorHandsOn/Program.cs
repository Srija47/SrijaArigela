using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorHandsOn
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 10;
            byte b1 = (byte)(b + 10);
            Console.WriteLine(b1);
            int i = 23;
            byte b2= (byte)i;
            long l2 = 12500;
            float f = 12.5f;
            int i3 = (int)f;
            float a1 = 1f;
            int a2 = 4;
            float a3 = a1 + a2;
            double a4 = 2;
            int a5 = (int)a4;
            Console.WriteLine(i);
            Console.WriteLine(l2);
            Console.WriteLine(f);
            Console.WriteLine(a3);
            Console.WriteLine(a5);
            Console.ReadKey();
        }
    }
}
