using abstract_classes_interfaces.Core.Abstract;
using System;

namespace abstract_classes_interfaces.Core.Models
{
    public class Programmer : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }

        public Programmer(string name, int age, double baseSalary, double bonus, double hourlyRate, int hoursWorked)
            : base(name, age, baseSalary, bonus)
        {
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }

        public override void CalculateSalary()
        {
            double salary = BaseSalary + HourlyRate * HoursWorked + Bonus;
            Console.WriteLine($"Programmer's Salary: {salary} (includes coffee-powered productivity bonus)");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Programmer Name: {Name}, Age: {Age}");
        }
    }
}