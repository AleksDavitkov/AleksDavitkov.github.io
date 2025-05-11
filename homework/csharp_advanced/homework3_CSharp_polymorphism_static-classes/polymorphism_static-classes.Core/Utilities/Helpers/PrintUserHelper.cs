using polymorphism_static_classes.Core.Domain.Models;

namespace polymorphism_static_classes.Core.Utilities.Helpers
{
    public static class PrintUserHelper
    {
        public static void Print(List<User> users)
        {
            if (users.Count == 0)
                Console.WriteLine("No users found.");
            else
                foreach (var user in users)
                    Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Age: {user.Age}");
        }

        public static void Print(User user)
        {
            if (user == null)
                Console.WriteLine("User not found.");
            else
                Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Age: {user.Age}");
        }
    }
}