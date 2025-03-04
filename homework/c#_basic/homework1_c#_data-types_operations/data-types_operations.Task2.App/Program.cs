namespace data_types_operations.Task2.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Average Number

            Console.Write("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Did your cat type that for you? Please enter a valid number.");
                return;
            }

            Console.Write("Enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Did your cat type that for you? Please enter a valid number.");
                return;
            }

            Console.Write("Enter the third number: ");
            if (!double.TryParse(Console.ReadLine(), out double num3))
            {
                Console.WriteLine("Did your cat type that for you? Please enter a valid number.");
                return;
            }

            Console.Write("Enter the fourth number: ");
            if (!double.TryParse(Console.ReadLine(), out double num4))
            {
                Console.WriteLine("Did your cat type that for you? Please enter a valid number.");
                return;
            }

            // Calculate average
            double average = (num1 + num2 + num3 + num4) / 4;

            // Result
            Console.WriteLine($"Average: {average}");
        }
    }
}
