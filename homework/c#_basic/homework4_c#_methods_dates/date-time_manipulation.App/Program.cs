namespace date_time_manipulation.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTimeManipulation();
        }
        static void DateTimeManipulation()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine($"Date 3 days from now: {today.AddDays(3):yyyy-MM-dd}");
            Console.WriteLine($"Date one month from now: {today.AddMonths(1):yyyy-MM-dd}");
            Console.WriteLine($"Date one month and 3 days from now: {today.AddMonths(1).AddDays(3):yyyy-MM-dd}");
            Console.WriteLine($"Date 1 year and 2 months ago: {today.AddYears(-1).AddMonths(-2):yyyy-MM-dd}");
            Console.WriteLine($"Current month: {today:MMMM}");
            Console.WriteLine($"Current year: {today:yyyy}");
        }
    }
}
