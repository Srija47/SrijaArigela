using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1.Insert\n2.Display\n3.Update\n4.Delete\n");
            
            List<Employee> elist = new List<Employee>();
            while (true)
            {
                Console.WriteLine("Enter your choice:");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                            Console.WriteLine("Please enter Employee Details:");
                            Console.WriteLine("Enter Employee Id:");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter Employee Name:");
                            string ename = Console.ReadLine();
                            Console.WriteLine("Enter Employee_Designation:");
                            string eds = Console.ReadLine();
                            Employee y = new Employee(id, ename, eds);
                            elist.Add(y);
                            Console.WriteLine("Press any key to continue\n");
                        break;
                    case 2:
                        Console.WriteLine("Display all Employee details:");
                        foreach (var s in elist)
                            Console.WriteLine(s.ToString());
                        Console.WriteLine("Press any key to continue\n");
                        break;
                    case 3:
                        Console.WriteLine("Enter ID to update:");
                        id = int.Parse(Console.ReadLine());
                        foreach (Employee i in elist)
                        {
                            if (i.empId == id)
                            Console.WriteLine("Enter ID and Designation to update:");
                            id = int.Parse(Console.ReadLine());
                            string des = Console.ReadLine();
                            i.empId = id;
                            i.empdes = des;
                            Console.WriteLine("Press any key to continue\n");
                            
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter ID to delete:");
                        id = int.Parse(Console.ReadLine());
                        Employee e = elist.Find(a => a.empId == id);
                        elist.Remove(e);
                        break;
                }
                Console.ReadLine();
            }
            
        }
    }
}
