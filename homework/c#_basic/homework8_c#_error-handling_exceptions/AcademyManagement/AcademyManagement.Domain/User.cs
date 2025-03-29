using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Domain
{
    public class User
    {
        public string Username { get; set; }
        public string Role { get; set; }
        public string CurrentSubject { get; set; }
        public List<string> Grades { get; set; }

        public User(string username, string role, string subject = null, List<string> grades = null)
        {
            Username = username;
            Role = role;
            CurrentSubject = subject;
            Grades = grades ?? new List<string>(); // if grades are not provided, create an empty list; this also depends on the role.
        }
    }
}