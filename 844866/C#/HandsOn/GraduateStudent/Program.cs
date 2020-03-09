using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            UnderGraduate ug = new UnderGraduate();
            Graduate g = new Graduate();
            Console.WriteLine("Enter Grade:\t");
            float grade = float.Parse(Console.ReadLine());
            Console.WriteLine("Grade for UnderGraduate:\t");
            Console.WriteLine(ug.Ispassed(grade));
            float grade1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Grade for Graduate:\t");
            Console.WriteLine(g.Ispassed(grade));
            Console.ReadLine();
        }
    }
}
