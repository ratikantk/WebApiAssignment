using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeDataWebApi.Context;
using EmployeeDataWebApi.Interfaces;
using EmployeeDataWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDataWebApi.Repositories
{

    public class EmployeeRepository : IEmployee
    {
        private readonly EmployeeDbConext _employeeDbContext;
        public EmployeeRepository(EmployeeDbConext employeeDbContext)
        {
          _employeeDbContext = employeeDbContext ;

        }
        public List<Employee> GetEmployeeDetails()
        {
            var records = _employeeDbContext.Employees.Select(x => new Employee() 
             { 
               EmpId = x.EmpId,
               FirstName=x.FirstName,
               LastName=x.LastName,
               Designation=x.Designation,
               DateOfBirth=x.DateOfBirth,
               Email=x.Email
             }
            ).ToList();
            return records;
            //try
            //{
            //    return _employeeDbContext.Employees.ToList();
            //}
            //catch (Exception e)
            //{
            //    throw;
            //}
        }
        public Employee GetEmployeeDetails(int id)
        {
            try
            {
                Employee? employee = _employeeDbContext.Employees.Find(id);
                if (employee != null)
                {
                    return employee;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
        public void UpdateEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }
            Employee employee1 = _employeeDbContext.Employees.FirstOrDefault(s => s.EmpId == employee.EmpId);
            if (employee1 == null)
            {
                throw new ArgumentNullException(nameof(employee1));
            }
            employee1.FirstName = employee.FirstName;
            employee1.LastName = employee.LastName;
            employee1.Designation = employee.Designation;
            employee1.Email = employee.Email;
            employee1.DateOfBirth = employee.DateOfBirth;

            _employeeDbContext.Attach(employee1).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _employeeDbContext.SaveChanges();
        }
        public void AddEmployee(Employee employee)
        {
            if(employee==null)
            {
                throw new ArgumentNullException(nameof(employee));
                
            }
             _employeeDbContext.Employees.Add(employee);
             _employeeDbContext.SaveChanges();

        }

        public void DeleteEmployee(int? id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            Employee employee = _employeeDbContext.Employees.FirstOrDefault(s => s.EmpId == id) ;
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee));
            }
            _employeeDbContext.Employees.Remove(employee);
            _employeeDbContext.SaveChanges();
        }

    }
}
