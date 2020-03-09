using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduateStudent
{
    public abstract class Student
    {
        protected string name;
        protected int studentId;
       // protected float grade;
        public abstract bool Ispassed(float grade);
    }
    class UnderGraduate : Student
    {
        public override bool Ispassed(float grade)
        {
            //Console.WriteLine("Grade");
            if(grade>70.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Graduate:Student
    {
        public override bool Ispassed(float grade)
        {
            //Console.WriteLine("Grade");
            if (grade > 80.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
