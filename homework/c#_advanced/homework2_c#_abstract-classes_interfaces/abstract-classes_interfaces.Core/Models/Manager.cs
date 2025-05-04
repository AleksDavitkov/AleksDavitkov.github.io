using abstract_classes_interfaces.Core.Abstract;

namespace abstract_classes_interfaces.Core.Models
{
    public class Manager : Employee
    {
        public int TeamSize { get; set; }
        public int MicromanagedEmployeesDailyCount { get; set; }

        public Manager(string name, int age, double baseSalary, double bonus, int teamSize, int micromanagedEmployeesDailyCount)
            : base(name, age, baseSalary, bonus)
        {
            TeamSize = teamSize;
            MicromanagedEmployeesDailyCount = micromanagedEmployeesDailyCount;
        }

        public override void CalculateSalary()
        {
            double totalSalary = BaseSalary + Bonus + (MicromanagedEmployeesDailyCount * 10); // Because stress pays
            Console.WriteLine($"Manager's Salary: {totalSalary} (includes micromanagement tax)");
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager Name: {Name}, Age: {Age}");
        }
    }
}