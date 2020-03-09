using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAssign
{
    public abstract 
        class Student
    {
        protected int studId;
        protected string studName;
        protected double examFee;
        public Student(int id,string name,double eFee)
        {
            this.studId=id;
            this.studName = name;
            this.examFee = eFee;
        }
        public virtual void displayDetails()
        {
            Console.WriteLine("Student ID:"+id+"\nStudent Name: "+ this.name+"\nExam Fee"+this.eFee);
        }
        public virtual void payfee()
        {
            Console.WriteLine("You should pay the Exam Fee" + this.eFee);
        }


    }
    class DayScholar:Student
    {
        double transportfee;
        public DayScholar(int id, string name, double eFee,double transportfee):base(id,name,eFee)
        {
            this.transportfee = transportfee;
        }
        public override void displayDetails()
        {
            Console.WriteLine("Student ID:" + id + "\nStudent Name: " + this.name + "\nExam Fee" + this.eFee+);
        }
        public override void payfee()
        {
            //return 0;
        }

    }
    class Hosteller : Student
    {
        double hostelfee;
        public Hosteller(int id, string name, double eFee, double hostelfee) : base(id, name, eFee)
        {
            this.hostelfee = hostelfee;
        }
        public override void displayDetails()
        {
            
        }
        public override void payfee()
        {
            //return 0;
        }

    }
}
