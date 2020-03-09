using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Shape picture = new Shape();
             picture.draw();
             picture.draw(10);
             picture.draw(10,20);
             picture.draw(12,23,12);
             picture.draw(1,1,1,"Cube");
             */


            // Dynamic polymorphism code
            //A obj = new A();
            A obj;
            /*obj.Display();
            obj = new B();
            obj.Display();
            obj = new C();
            obj.Display();
            */
            obj = new B();
            obj.Display();
            obj = new C();
            obj.Display();
            Console.ReadKey();

        }
    }
}
