using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            Console.WriteLine("Enter Numbers:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int res=cal.Add(x,y);
            Console.WriteLine("Add:"+res);
            cal.Subtract(x,y,out int sub);// returns value using out
            Console.WriteLine("Subtraction:"+sub);
            //call ----by----value
            cal.Swap(x,y);
            //call ----by----reference
            cal.Swap(ref x, ref y);
            Console.WriteLine("Swapping of numbers:" +x + " " + y);
            Console.ReadLine();
        }
    }
}
