using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignOOP
{
    class Student
    {
        static string cname = "CRR";
        int rollno;
        string name;
        string branch;
        int clas, sem;
        int[] marks = new int[5];
        public int Rollno { get => rollno; set => rollno = value; }
        public int Sem { get => sem; set => sem = value; }
        public int Clas { get => clas; set => clas = value; }
        public string Branch { get => branch; set => branch = value; }
        public string Name { get => name; set => name = value; }
        static Student()
        {
            cname = "CRR";
        }
        public Student(int rollno, string name, int clas, string branch,int sem)
        {

            this.rollno = rollno;
            this.name = name;
            this.branch = branch;
            this.clas = clas;
            this.sem = sem;
        }
        public void displayresult()
        {
            float sum = 0;
            int flag=0;
            for (int i = 0; i < 5; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
                sum = sum + marks[i];
            }
            double avg = sum / 5;
            Console.WriteLine("Average:"+avg);
            for (int i = 0; i < 5; i++)
            {
                
                if (marks[i]<35)
                {
                    //Console.WriteLine("Failed");
                    //break;
                    flag = 0;
                }
                else if(marks[i]>35)
                {
                    if (avg < 50)
                    {
                        //Console.WriteLine("Failed");
                        //break;
                        flag = 0;
                    }
                    else
                        //Console.WriteLine("Pass");
                        flag = 1;
                }
            }
            if (flag == 0)
                Console.WriteLine("Failed");
            else
                Console.WriteLine("Pass");
        }
        public void Display()
        {

            Console.WriteLine(" "+name+" "+rollno+" "+branch+" "+sem);
        }

    }
}
