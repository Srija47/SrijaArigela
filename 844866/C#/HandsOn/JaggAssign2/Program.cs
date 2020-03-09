using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggAssign2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[2][];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter the size" + (i + 1));
                int size = int.Parse(Console.ReadLine());
                arr[i] = new int[size];
            }
            for (int row = 0; row < 2; row++)
            {
                for ( int col = 0; col < arr[row].Length; col++)
                {
                    arr[row][col] = int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < arr[row].Length; col++)
                {
                    Console.Write(" " + arr[row][col] + "\t");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for(int row=0;row<2;row++)
            {
                for(int col=0;col< arr[row].Length; col++)
                {
                    if(arr[row][col]==arr[row+1][col+1])
                    {
                        sum = sum + arr[row][col];
                        Console.WriteLine(sum);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
