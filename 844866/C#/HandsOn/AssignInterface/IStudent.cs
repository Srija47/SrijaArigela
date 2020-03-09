using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignInterface
{
       public interface IStudent
        {
        int StudentId { get; set; }
        string Name { get; set; }
        void ShowDetails(int studentid, string name);
        
        }
    class DayScholar:IStudent
    {
        string name;
        int studentid;
        string IStudent.Name { get =>name; set => name = value; }
        int IStudent.StudentId { get => studentid; set => studentid = value; }
        public DayScholar(int studentid, string name)
        {
            this.name = name;
            this.studentid = studentid;
        }
        public void ShowDetails(int studentid, string name)
        {
            Console.WriteLine(" Student Name:"+this.name+"\nStudent Id:"+this.studentid);
        }
    }
    class Resident:IStudent
    {
        string name;
        int studentid;
        string IStudent.Name { get => name; set => name = value; }
        int IStudent.StudentId { get => studentid; set => studentid = value; }
        public Resident(int studentid, string name)
        {
            this.name = name;
            this.studentid = studentid;
        }
        public void ShowDetails(int studentid, string name)
        {
            Console.WriteLine(" Student Name:" + this.name + "\nStudent Id:" + this.studentid);
        }

    }
}
