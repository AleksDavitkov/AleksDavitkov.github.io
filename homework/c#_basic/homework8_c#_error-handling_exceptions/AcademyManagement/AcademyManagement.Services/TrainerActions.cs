using AcademyManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Services
{
    public class TrainerActions
    {
        private static List<User> students = new List<User>
        {
            new User("student1", "Student", "Math", new List<string> { "10", "9", "10" }),
            new User("student2", "Student", "Science", new List<string> { "8", "6", "9" })
        };

        private static List<string> subjects = new List<string> { "Math", "Science" };

        public static void TrainerOptions()
        {
            Console.WriteLine("Trainer Options:");
            Console.WriteLine("1. View Students");
            Console.WriteLine("2. View Subjects");
            Console.Write("Choose an option: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewStudents();
                    break;
                case "2":
                    ViewSubjects();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        public static void ViewStudents()
        {
            Console.WriteLine("List of Students:");
            foreach (var student in students)
            {
                Console.WriteLine(student.Username);
            }
        }

        public static void ViewSubjects()
        {
            Console.WriteLine("List of Subjects with Student Count:");
            foreach (var subject in subjects)
            {
                var studentCount = students.Count(s => s.CurrentSubject == subject);
                Console.WriteLine($"{subject}: {studentCount} students enrolled");
            }
        }
    }
}