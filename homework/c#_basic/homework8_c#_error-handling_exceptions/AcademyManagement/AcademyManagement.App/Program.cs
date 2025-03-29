using System;
using AcademyManagement.Domain;
using AcademyManagement.Services;

namespace AcademyManagement.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Academy Management System");
            User loggedInUser = null;

            while (loggedInUser == null)
            {
                Console.Write("Enter username: ");
                string username = Console.ReadLine();
                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                try
                {
                    loggedInUser = LoginService.Login(username, password);
                    Console.WriteLine($"Login successful! Welcome, {loggedInUser.Username} ({loggedInUser.Role})");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            // show options based on the role
            RoleActions.ShowOptions(loggedInUser);

            Console.WriteLine("Plenty of room to improve, though getting the concept is more than ok for now");
        }
    }
}