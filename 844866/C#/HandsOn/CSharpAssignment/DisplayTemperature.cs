using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment
{
    class DisplayTemperature
    {
        public static double Temperature(double Fahrenheit)
        {
            double celsius = (Fahrenheit - 32) * 5 / 9;
            return celsius;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nGive a Temperature in Fahrenheit.\n");
            double Fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine(Temperature(Fahrenheit));
            Console.ReadKey();
        }
}
}
