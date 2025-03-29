using AcademyManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Services
{
    public class StudentActions
    {
        private static List<User> students = RoleActions.GetStudents();

        public static void StudentAction(User user)
        {
            Console.WriteLine("Student Options:");
            Console.WriteLine("1. View Subject");
            Console.WriteLine("2. View Grades");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            // LINQ and lambda expression combined usage to find the student by username
            // StringComparison.OrdinalIgnoreCase is for case-insensitive comparison * yes I prompted this block
            var student = students.FirstOrDefault(s => s.Username.Equals(user.Username, StringComparison.OrdinalIgnoreCase));
            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"Current Subject: {student.CurrentSubject}");
                    break;
                case "2":
                    if (student.Grades != null && student.Grades.Any())
                    {
                        Console.WriteLine("Grades: ");
                        foreach (var grade in student.Grades)
                        {
                            Console.WriteLine(grade);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No grades available.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}