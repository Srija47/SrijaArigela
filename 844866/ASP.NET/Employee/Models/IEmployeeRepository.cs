using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{
    public interface IEmployeeRepository
    {
        Employee1 GetEmployee1(int id);
        List<Employee1> DisplayDetails();
        bool AddEmployee(Employee1 emp);
    }
}
