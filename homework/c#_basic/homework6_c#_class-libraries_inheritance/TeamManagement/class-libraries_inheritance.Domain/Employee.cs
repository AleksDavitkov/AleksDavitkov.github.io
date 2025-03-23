using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManagement.class_libraries_inheritance.Domain.Enums;

namespace TeamManagement.class_libraries_inheritance.Domain
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role JobRole { get; set; }
        protected double Salary { get; set; }

        public Employee(string firstName, string lastName, Role jobRole, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            JobRole = jobRole;
            Salary = salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Employee: {FirstName} {LastName}, Salary: {Salary}");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
    }
}