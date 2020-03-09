using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trainee> elist = new List<Trainee>();
            Console.WriteLine("Enter Number OF Trainees");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Trainee Id:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Trainee Name:");
                string tname = Console.ReadLine();
                Console.WriteLine("Enter Project Id:");
                int pid = int.Parse(Console.ReadLine());
                Trainee y = new Trainee(id, tname, pid);
                elist.Add(y);
            }
            List<Trainee> pd = elist.FindAll(y => y.projectid != -1);
            foreach (Trainee t in pd)
            {
                Console.WriteLine(t);
            }

            Console.ReadLine();
        }

    }
}
