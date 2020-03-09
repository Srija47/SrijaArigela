using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighestAndSmallestNumber
{
    class Array2D
    {
        static void Main()
        {
            int[,] marks = new int[5, 3];
            for(int row=0;row<5;row++)
            {
                for(int col=0;col<3;col++)
                {
                    marks[row,col]= int.Parse(Console.ReadLine());
                }
            }
            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.WriteLine(marks[row,col]);
                    Console.WriteLine();
                }
            }
            foreach(int x in marks)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}
