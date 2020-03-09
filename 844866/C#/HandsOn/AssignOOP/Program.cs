using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Roll Number:");
            int rollno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Student Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Class:");
            int clas = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Branch:");
            string branch = Console.ReadLine();
            Console.WriteLine("Enter the sem:");
            int sem = int.Parse(Console.ReadLine());
            Student s = new Student(rollno,name,clas,branch,sem);
            Console.WriteLine("Enter 5 Subject Marks:");
            s.displayresult();
            s.Display();
            Console.ReadKey();
        }
    }
}
