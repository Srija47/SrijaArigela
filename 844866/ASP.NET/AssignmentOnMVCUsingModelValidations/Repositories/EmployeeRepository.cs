using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentOnMVCUsingModelValidations.Models;

namespace AssignmentOnMVCUsingModelValidations.Repositories
{
    public class EmployeeRepository
    {
        public static List<Employee> list = new List<Employee>()
            { new Employee(){EmpId=23,
                Name = "Rohan",
                Designation = "FSE",
                ProjectName= "JAVA",
                Password = "12345"
            } };
        public EmployeeRepository()
        {

        }
        public void Add(Employee item)
        {
            list.Add(item);//Add User Data into list
        }
        public Employee Validate(int eid, string pwd)
        {
            foreach (var item in list)
            {
                if (item.EmpId == eid && item.Password == pwd)
                {
                    return item;
                }
            }
            return null;
        }
    }
}

