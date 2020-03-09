using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestAndSmallestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter count of numbers");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int high, low;
            Console.WriteLine("Enter numbers");
            for (int i=0;i<n;i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            high = numbers[0];
            low = numbers[0];
            for (int i = 0; i < n; i++)
            {
                if (numbers[i] > high) 
                    high = numbers[i];
                if (numbers[i] < low) 
                    low = numbers[i];
            }
            Console.WriteLine("Highest Number:" +high + "\n" + "Lowest Number:"+low);
            Console.ReadKey();
        }
    }
}
