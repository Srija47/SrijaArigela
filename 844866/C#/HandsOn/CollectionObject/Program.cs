using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> elist = new List<Employee>();
            elist.Add(new Employee("Raj", "111", 100000));
            elist.Add(new Employee("Rajesh", "112", 200000));
            elist.Add(new Employee("John", "111", 14000));
            elist.Add(new Employee("Ajay", "111", 12000));
            List<Employee> highpay = elist.FindAll(e => e.salary > 12000);
            foreach (Employee el in highpay)
            {
                Console.WriteLine(el.ToString());
            }

            Console.ReadLine();


        }
    }
}
