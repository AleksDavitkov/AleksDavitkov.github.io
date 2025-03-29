using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademyManagement.Domain;

namespace AcademyManagement.Services
{
    public class LoginService
    {
        private static List<User> users = new List<User>
        {
            new User("admin", "admin", null, null),
            new User("trainer1", "trainer", null, null),
            new User("student1", "student", "Math", new List<string> { "10", "9", "10" }),
            new User("student2", "student", "Science", new List<string> { "8", "6", "9" })
        };

        public static User Login(string username, string password)
        {
            // in a real scenario, password verification process also here
            var user = users.FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                return user;
            }
            else
            {
                throw new Exception("Invalid username or password.");
            }
        }
    }
}