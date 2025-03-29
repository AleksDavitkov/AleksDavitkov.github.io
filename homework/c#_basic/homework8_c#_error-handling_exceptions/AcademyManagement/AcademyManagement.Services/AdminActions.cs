using AcademyManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Services
{
    public class AdminActions
    {
        private static List<User> users = new List<User>
        {
            new User("admin", "admin", null, null),
            new User("trainer1", "trainer", null, null),
            new User("student1", "student", "Math", new List<string> { "A", "B", "C" }),
            new User("student2", "student", "Science", new List<string> { "B", "B", "A" })
        };

        public static void AddUser(string username, string role)
        {
            var user = new User(username, role);
            users.Add(user);
            Console.WriteLine($"User {username} with role {role} added.");
        }

        public static void RemoveUser(string username, string loggedInUsername)
        {
            var userToRemove = users.FirstOrDefault(u => u.Username == username);
            if (userToRemove != null && userToRemove.Username != loggedInUsername)
            {
                users.Remove(userToRemove);
                Console.WriteLine($"User {username} removed");
            }
            else
            {
                Console.WriteLine("User not found or you cannot remove yourself");
            }
        }
    }
}