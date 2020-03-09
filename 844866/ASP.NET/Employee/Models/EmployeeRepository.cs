using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{
    public class EmployeeRepository:IEmployeeRepository
    {
           public List<Employee1> employeeList;
            public EmployeeRepository()
            {
            employeeList = new List<Employee1>() { new Employee1(1, "Ajay", "abc@gmail.com", Dept.IT),
                                                   new Employee1(2, "Raj", "Raj123@gmail.com",Dept.Insurance),
                                                   new Employee1(3, "Priya", "priya4567@gmail.com",Dept.IT)
                                };
            }
        public Employee1 GetEmployee1(int id)
        {
            Employee1 e = employeeList.FirstOrDefault(e => e.Id == id);
            return e;
        }
        public List<Employee1> DisplayDetails()
        {
            return employeeList;
        }
        public bool AddEmployee(Employee1 emp)
        {
            emp.Id = employeeList.Max(e => e.Id) + 1;
            employeeList.Add(emp);
            return true;
        }
        
    }
}
