using TeamManagement.class_libraries_inheritance.Domain;
using TeamManagement.class_libraries_inheritance.Domain.Enums;

namespace class_libraries_inheritance.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager managerSales = new Manager("John", "Doe", "Sales");
            Manager managerMarketing = new Manager("Jane", "Smith", "Marketing");
            Contractor contractor1 = new Contractor("Jill", "Wayne", 40, 20, managerSales);
            Contractor contractor2 = new Contractor("Bob", "Bobsky", 35, 25, managerMarketing);
            SalesPerson salesPeson1 = new SalesPerson("Alice", "Johnson");

            Employee[] Company = new Employee[]
            {
                managerSales,
                managerMarketing,
                contractor1,
                contractor2,
                salesPeson1
            };

            CEO ceo = new CEO("Ron", "Ronsky", 100, 14);

            // Employees array to CEO's list
            // Good example of polymorphism, CEO has a list of Employees, but the Employee is an array.
            // Also, AddRange() is a method available for List (researched this). Adding multiple elements at once.
            ceo.Employees.AddRange(Company);

            ceo.PrintInfo();
            Console.WriteLine($"Total salary along with extras: {ceo.GetSalary()}");
            ceo.PrintEmployees();
        }
    }
}