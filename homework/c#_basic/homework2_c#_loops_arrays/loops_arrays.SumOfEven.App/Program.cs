﻿namespace loops_arrays.SumOfEven.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Note * Using functions for this homework wasn't specified
            // However, knowing it's good practice and I decided for a cleaner approach

            int[] numbers = new int[6];

            Console.WriteLine("Enter 6 integers. The even numbers will be summed");

            GetInputs(numbers);

            int sum = CalculateSumOfEvens(numbers);

            Console.WriteLine($"The result is: {sum}");
        }

        // Check if input is a valid integer (failsafe, prevent user from accidentally or intentionally breaking the program)
        static void GetInputs(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int input = 0;
                bool validInput = false;

                // Don't let the user proceed until the input is satisfied
                while (!validInput)
                {
                    Console.WriteLine($"Enter integer no.{i + 1}:");
                    string userInput = Console.ReadLine();

                    // Confirm validity
                    validInput = int.TryParse(userInput, out input);

                    if (!validInput)
                    {
                        Console.WriteLine("Invalid input! Enter a valid number");
                    }
                }

                numbers[i] = input;  // Feed the integer into the array
            }
        }

        static int CalculateSumOfEvens(int[] numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }
    }
}