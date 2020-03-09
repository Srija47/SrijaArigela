using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    class Student
    {
        string name; 
        string branch;
        int rollno;
        int sem;
        int marks;// read only property
        public int RollNo{ get => rollno; set=> rollno = value; }
        private int Marks
        {
            get { return marks; }
            set { marks = value; }
        }
        public int Sem
        {
            get { return sem; }
            set { sem = value; }
        }
        public string Name { get; set; }
        private string Branch
        {
            get { return branch; }
            set { branch = value; }
        }
        public Student()//default constructor
        {
           this.sem = 3;
            this.rollno = 0;
            this.marks = 0;
            this.Name = "";
            this.branch = "cse";
            Console.WriteLine(""+this.branch);
        }
        // Multiple Constructors
        public Student(string name,int rollno,string branch,int sem,int marks)
        {
            this.Name = name;
            this.RollNo = rollno;
            this.Branch = branch;
            this.Marks = marks;
            this.sem = sem;
        }
        public void AcceptDetails()
        {
            Console.WriteLine("Enter Student Details: ");
            //rollno = int.Parse(Console.ReadLine());
            //name = Console.ReadLine();
            this.branch= Console.ReadLine();
            //sem = int.Parse(Console.ReadLine());
            this.marks= int.Parse(Console.ReadLine());
            Console.WriteLine("Student Details are Accepted.\n ");
        }
        public void DisplayDetails()
        {
            //Console.WriteLine(""+rollno+"\t"+""+name+"\t"+""+branch+"\t"+""+sem+"\t"+""+marks);
            Console.WriteLine("" + this.Name + "\t" + "" + this.RollNo + "\t"  + "" + this.Sem + "\t" + "" + Marks + "\t" + "" + Branch);
            Console.WriteLine("Student Details are Displayed.");

        }
        static void Main(string[] args)

        {
            Student student1 = new Student();
            
            //student1.Name = "John";
            //student1.rollno = 25;
            //student1.Sem = 8;
            //Student data = new Student();
            //student1.AcceptDetails();
            student1.DisplayDetails();
            Student student2 = new Student("Raj",120,"ECE",8,98);
            student2.DisplayDetails();
            Student student3 = new Student("Rani", 190, "CSE", 8, 78);
            student3.DisplayDetails();
            Console.ReadLine();
        }
    }
}
