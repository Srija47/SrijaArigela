using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoHierarchical
{
    abstract class Vehicle
    {
        protected string color;
        public Vehicle()//parent default constructor invoke automatically for all child objects.
        {
            this.color = "White";
            Console.WriteLine("Constructor from Vehicle\n ");
        }
        public Vehicle(string clr)//parent parameter constructor has to be invoked using base keyword and a value
        {
            this.color = clr;
            Console.WriteLine("Parameter Constructor from Vehicle\n ");
        }
        public abstract void fill_fuel();//child should compulsory override
        public virtual void start()// child may or may not override
        {
            Console.WriteLine("Vehicle Started ");
        }
        public void stop()
        {
            Console.WriteLine("Vehicle Stopped");
        }
    }
    class Bus : Vehicle
    {

        int seating;
        int speed;
        public Bus():base("Red")
        {
            this.seating = 80;
            this.speed = 120;
            Console.WriteLine("Constructor from Bus\n ");
        }
        public override void fill_fuel()
        {
            Console.WriteLine("Filled diesel\n ");
        }
        public void Run()
        {
            Console.WriteLine(this.color + " Bus is Running at speed " + this.speed + " with " + this.seating + " Passengers");
        }
    }
    class Car : Vehicle
    {
        string type;
        int speed;
        public Car()
        {
            this.type = "hmodel";
            this.speed = 120;
            Console.WriteLine("Constructor from Car\n ");
        }
        public Car(string clr,int spd,string type):base(clr)
        {
            //this.color= clr;
            this.speed = spd;
            this.type = type;
        }
        public override void fill_fuel()
        {
            Console.WriteLine("Filled diesel/prtrol/gas\n ");
        }
        public void Drive()
        {
            Console.WriteLine(this.color + " Car is Driving at speed\t " + this.speed + " with  " + this.type
                + "  Standard");
        }
    }
}