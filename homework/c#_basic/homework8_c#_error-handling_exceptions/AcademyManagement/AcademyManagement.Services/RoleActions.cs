using AcademyManagement.Domain;
using AcademyManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Services
{
    public class RoleActions
    {
        private static List<User> students = new List<User>
        {
            new User("student1", "student", "Math", new List<string> { "10", "9", "10" }),
            new User("student2", "student", "Science", new List<string> { "8", "6", "9" })
        };

        public static void ShowOptions(User user)
        {
            switch (user.Role.ToLower())
            {
                case "admin":
                    AdminActionsMenu(user);
                    break;
                case "trainer":
                    TrainerActionsMenu();
                    break;
                case "student":
                    StudentActions.StudentAction(user);
                    break;
                default:
                    Console.WriteLine("Invalid role.");
                    break;
            }
        }

        private static void AdminActionsMenu(User loggedInUser)
        {
            Console.WriteLine("Admin Options:");
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Remove User");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter username: ");
                    string username = Console.ReadLine();
                    Console.Write("Enter role: ");
                    string role = Console.ReadLine();
                    AdminActions.AddUser(username, role);
                    break;

                case "2":
                    Console.Write("Enter username to remove: ");
                    string removeUser = Console.ReadLine();
                    AdminActions.RemoveUser(removeUser, loggedInUser.Username); // pass loggedInUser
                    break;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

        private static void TrainerActionsMenu()
        {
            Console.WriteLine("Trainer Options:");
            Console.WriteLine("1. View Students");
            Console.WriteLine("2. View Subjects");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice) // display intent
            {
                case "1":
                    ViewStudents();
                    break;
                case "2":
                    ViewSubjects();
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

        private static void ViewStudents()
        {
            Console.WriteLine("List of students:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Username} - {student.CurrentSubject}");
            }
        }

        private static void ViewSubjects()
        {
            Console.WriteLine("Available subjects: Math, Science");
        }

        public static List<User> GetStudents()
        {
            return students; // get all students
        }
    }
}