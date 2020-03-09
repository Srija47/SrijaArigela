using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHierarchical
{
    class Program
    {
        static void Main(string[] args)
        {
           // Vehicle veh = new Vehicle();
            //Car alto = new Car();
            Car alto1= new Car("blue",150,"Premium");
            Bus volvo = new Bus();
            //veh.start();
           // veh.stop();
            volvo.start();
            volvo.Run();
            volvo.fill_fuel();
            volvo.stop();
            alto1.start();
            alto1.Drive();
            alto1.stop();
          // alto1.Drive();
            alto1.fill_fuel();
            Console.ReadKey();
        }
    }
}
