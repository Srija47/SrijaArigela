using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInheritance
{
    class Vehicle
    {
        string color;
        public Vehicle()
        {
            this.color = "White";
        }
        public void start()
        {
            Console.WriteLine("Vehicle Started ");
        }
        public void stop()
        {
            Console.WriteLine("Vehicle Stopped");
        }
    }
    class Bus:Vehicle
    {
       
        int seating;
        int speed;
        public Bus()
        {
            this.seating = 40;
            this.speed = 70;
        }
        public void Run()
        {
            Console.WriteLine(this.color+"Bus is Running at speed "+ this.speed +"with"+this.seating+"Passengers");
        }
    }
    class Car : Vehicle 
    {
        string type;
        int speed;
        public Car()
        {
            this.type = "dfgffd";
            this.speed = 120;
        }
        public void Drive()
        {
            Console.WriteLine(this.color + "Car is Driving at speed " + this.speed + "with" + this.type
                + "Passengers");
        }
    }
}
