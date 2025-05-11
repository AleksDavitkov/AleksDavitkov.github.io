using polymorphism_static_classes.Core.Domain.Models;

namespace polymorphism_static_classes.Core.DataAccess
{
    public static class UserDB
    {
        private static List<User> _users = new List<User>();

        static UserDB()
        {
            _users.Add(new User(1, "John", 30));
            _users.Add(new User(2, "Bob", 25));
            _users.Add(new User(3, "Jill", 35));
        }

        public static User SearchById(int id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public static List<User> SearchByName(string name)
        {
            return _users.Where(u => u.Name.ToLower() == name.ToLower()).ToList();
        }

        public static List<User> SearchByAge(int age)
        {
            return _users.Where(u => u.Age == age).ToList();
        }
    }
}