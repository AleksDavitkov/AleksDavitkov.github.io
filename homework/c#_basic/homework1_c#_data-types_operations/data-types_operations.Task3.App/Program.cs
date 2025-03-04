namespace data_types_operations.Task3.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Swap Numbers

            Console.Write("Input the First Number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input! Enter a valid number.");
                return;
            }

            Console.Write("Input the Second Number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input! Enter a valid number.");
                return;
            }

            // Initiate Swap
            double memoryCell = num1;
            num1 = num2;
            num2 = memoryCell;

            // Result
            Console.WriteLine("Swapped result:");
            Console.WriteLine($"First Number: {num1}");
            Console.WriteLine($"Second Number: {num2}");
        }
    }
}
