using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoFactory
{
    //product interface
    interface Ifactory
    {
        void manufacture(int cnt);
    }
    class Bike:Ifactory
    {
        public void manufacture(int cnt)
        {
            Console.WriteLine("Bike Manufacturing No:" +cnt );
        }
    }
    class Car : Ifactory
    { 
        public void manufacture(int cnt)
        {
            Console.WriteLine("Car Manufacturing No:" + cnt);
        }
    }
    //create class
    abstract class VehicleFactory
    {
        public abstract Ifactory generateVehicles(string type);
    }
    //actual creation class
    class ConcreteVehicleFactory:VehicleFactory
    {
        public override Ifactory generateVehicles(string type)
        {
            if (type == "Bike") return new Bike();
            else return new Car();
         
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        VehicleFactory obj = new ConcreteVehicleFactory();
        Ifactory myVehicle = obj.generateVehicles("Bike");
        myVehicle.manufacture(10);
        myVehicle = obj.generateVehicles("Bike");
        myVehicle.manufacture(10);
        Console.ReadLine();
         }
    }
}

