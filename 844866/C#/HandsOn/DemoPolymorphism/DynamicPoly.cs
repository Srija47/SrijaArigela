using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    /* class A
     {
         public virtual void Display()
         {
             Console.WriteLine("Display A class details\n");
         }

     }*/
    abstract class A
    {
        public abstract
            
            void Display();

    }
    class B:A
    {
        public override void Display()
        {
            Console.WriteLine("Display B class details\n");
        }

    }
    class C : A
    {
        public override void Display()
        {
            Console.WriteLine("Display C class details\n");
        }

    }
}
