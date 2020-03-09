using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIDemo2.Models;

namespace HandsOnAPIDemo2.Repositories
{
    public class EmployeeRepository
    {
        //Get all Employees
        public List<Employee> GetAll()
        {
            using (EmpDBContext db=new EmpDBContext())
            {
                return db.Employee.ToList();
            }
        }
        //Get employee by id
        public Employee GetById(int eid)
        {
            using (EmpDBContext db=new EmpDBContext())
            {
                return db.Employee.Find(eid);
            }
        }
        //Add Employee
        public void Add(Employee item)
        {
            using (EmpDBContext db=new EmpDBContext())
            {
                db.Employee.Add(item);
                db.SaveChanges();
            }
        }
        //Delete Record
        public void Delete(int eid)
        {
            using (EmpDBContext db=new EmpDBContext())
            {
                db.Employee.Remove(e);
                db.SaveChanges();
            }
        }
        //update record
        public void Update(Employee item) 
        {
            using (EmpDBContext db = new EmpDBContext())
            {
                db.Employee.Update(item);
                db.SaveChanges();
            }
        }

    }
}
