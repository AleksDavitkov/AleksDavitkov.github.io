using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManagement.class_libraries_inheritance.Domain.Enums;

namespace TeamManagement.class_libraries_inheritance.Domain
{
    public class Contractor : Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor(string firstName, string lastName, double workHours, int payPerHour, Manager responsible)
            : base(firstName, lastName, Role.Contractor, 0)
        {
            WorkHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        public override double GetSalary()
        {
            Salary = WorkHours * PayPerHour;
            return Salary;
        }

        public string CurrentPosition()
        {
            if (Responsible != null)
            {
                return Responsible.Department;
            }
            else
            {
                return "No manager assigned";
            }
        }
    }
}