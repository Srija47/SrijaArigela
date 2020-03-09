using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPartial
{
    partial class ClassA
    {
        partial void setData();//partial method declaration
        public void print()
        {
            Console.WriteLine("Class A printing");
            setData();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ClassA obj=new ClassA();
            obj.print();
            Console.ReadKey();
        }
    }
}
