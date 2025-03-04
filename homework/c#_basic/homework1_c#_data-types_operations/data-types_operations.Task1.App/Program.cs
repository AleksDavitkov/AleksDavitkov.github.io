namespace data_types_operations.Task1.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Real Calculator

            Console.WriteLine("Enter the first number: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                return;
            }

            Console.WriteLine("Enter the second number: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Invalid input! Please enter a number.");
                return;
            }

            Console.Write("Enter the Operation (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());

            double result = 0;

            // Perform an operation
            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error! Division by zero is not possible. At least in Earth-based math.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid Operation");
                    return;
            }

            // Show the result
            Console.WriteLine("Result = " + result);
        }
    }
}
