using System;
using System.Linq;
using HandsOnCodeFirst.Models;
using HandsOnCodeFirst.Context;
using System.Collections.Generic;

namespace HandsOnCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (MyContext db=new MyContext())
            {
                //insert a new record
                //Student s = new Student() { Sname = "Mohan", Age = 20, Std = "I" };
                //db.Students.Add(s);
                //db.SaveChanges();

                //Fetch record
                Student s = db.Students.Find(10);
                Console.WriteLine("Welcome {0}", s.Sname);
                //fetch one record using non primary key
                Student s1 = db.Students.SingleOrDefault(i => i.Sname == "Rohan");
                List<Student> list = db.Students.Where(i => i.Age == 10).ToList();
                List<Student> list1 = db.Students.Where(i => i.Age == 10 && i.Std=="II").ToList();

                //UPDATE record
                //Student s2 = db.Students.Find(9);
                //s2.Age = 21;//updating the value
                //db.Students.Update(s2);
                //db.SaveChanges();

                //delete record
                Student s3 = db.Students.SingleOrDefault(i => i.Sname == "Karan");
                db.Students.Remove(s3);
                db.SaveChanges();
            }
           
        }
    }
}
