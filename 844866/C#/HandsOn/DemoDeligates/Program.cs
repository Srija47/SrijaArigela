using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDeligates
{
    public delegate void DeligatePointer();// deligaet definition
    public delegate double calAreaPointer(double x);
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            
            //DeligatePointer mydeligate = new DeligatePointer(p.print);
            DeligatePointer mydeligate = p.print;
            mydeligate += p.Display;//multicast deligate
            mydeligate();
            mydeligate -= p.print;
            mydeligate();
            calAreaPointer cptr= Cal .calArea;//create a delegate object
            cptr += Calculate.caldist;//in multidelegates last method return type will return the value returned
            double area = cptr(20);
            Console.WriteLine(area);
            Console.ReadLine();
        }
        public void print()
        {
            Console.WriteLine("Welcome to Delegate");
        }
        public void Display()
        {
            Console.WriteLine("Welcome to Multicast Delegate");
        }
    }
}
