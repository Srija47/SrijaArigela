using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHandsOn
{
    class ArrayA
    {
        static void Main()
        {
            int[] a = new int[5] { 10, 12, 23, 34, 58 };
            //int sum = 0;
            foreach (int i in a)
            //sum=sum+i;
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);//print even values
                }
            }
            Console.ReadKey();
        }
    }
}
