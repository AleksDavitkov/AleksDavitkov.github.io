using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamManagement.class_libraries_inheritance.Domain.Enums;

namespace TeamManagement.class_libraries_inheritance.Domain
{
    public class CEO : Employee
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public int Shares { get; set; }
        private double _sharesPrice;

        public CEO(string firstName, string lastName, int shares, double sharesPrice)
            : base(firstName, lastName, Role.CEO, 5000)
        {
            Shares = shares;
            _sharesPrice = sharesPrice;
        }

        public void AddSharesPrice(double amount)
        {
            _sharesPrice = amount;
        }

        public override double GetSalary()
        {
            return base.GetSalary() + (Shares * _sharesPrice);
        }

        public void PrintEmployees()
        {
            Console.WriteLine($"{FirstName} {LastName}'s Employees:");
            if (Employees.Count == 0)
            {
                Console.WriteLine("No employees found.");
                return;
            }

            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.JobRole}");
            }
        }
    }
}