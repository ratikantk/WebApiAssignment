using EmployeeDataWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDataWebApi.Interfaces
{
    public interface IEmployee
    {
        public List<Employee> GetEmployeeDetails();
        public Employee GetEmployeeDetails(int id);
        public void AddEmployee(Employee employee);
        public void UpdateEmployee(Employee employee);
        public void DeleteEmployee(int? id);      

    }
}
