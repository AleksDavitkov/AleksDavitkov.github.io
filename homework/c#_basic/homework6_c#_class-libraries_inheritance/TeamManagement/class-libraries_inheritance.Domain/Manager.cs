using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManagement.class_libraries_inheritance.Domain.Enums;

namespace TeamManagement.class_libraries_inheritance.Domain
{
    public class Manager : Employee
    {
        private double _bonus = 0; // C# will automatically initialize this to 0, but it's good practice to avoid possible mistakes
        public string Department { get; set; }

        public Manager(string firstName, string lastName, string department)
            : base(firstName, lastName, Role.Manager, 1000)
        {
            Department = department;
        }

        public void AddBonus(double amount)
        {
            _bonus += amount;
        }

        public override double GetSalary()
        {
            return Salary + _bonus;
        }
    }
}