namespace methods.AgeCalculator.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetAge();
        }
        static void GetAge()
        {
            Console.Write("Enter your birthday (yyyy-mm-dd, e.g. 1999-01-03):");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
            {
                int age = AgeCalculator(birthDate);
                Console.WriteLine($"You are {age} years old.");
            }
            else
            {
                Console.WriteLine("Invalid date. Please follow yyyy-mm-dd format.");
            }
        }

        static int AgeCalculator(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            // If birthday hasn't happened yet
            if (birthDate.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }
    }
}
