using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggAssign
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] a = new int[size];
            if (size%2==0)
            {
                Console.WriteLine("Enter only odd number as size");
            }
            else
            {
                for(int i=0;i<size;i++)
                {
                    a[i] = int.Parse(Console.ReadLine());
                }
            }
            int first = a[0];
            int last = a[size-1];
            int middle = a[size / 2];
            if(size==1)
            {
                Console.WriteLine("The Largest:" + first);
            }
            else if(first>middle && first>last)
            {
                Console.WriteLine("The Largest:"+first);
            }
            else if(middle>first&& middle>last)
            {
                Console.WriteLine("The Largest:" + middle);
            }
            else
            {
                Console.WriteLine("The Largest:" + last);
            }
            Console.ReadKey();
        }
    }
}
