namespace collection_types.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbersQueue = new Queue<int>();
            collectNumbersQ(numbersQueue);
            printNumbers(numbersQueue);
        }

        static void collectNumbersQ(Queue<int> queue) // take in a queue as a parameter
        {
            bool continueInput = true;

            while (continueInput)
            {
                Console.Write("Enter a number: ");
                string userInput = Console.ReadLine();
                int number;

                if (int.TryParse(userInput, out number))
                {
                    queue.Enqueue(number);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

                Console.Write("Do you want to enter another number? (Y/N): ");
                string response = Console.ReadLine().ToUpper();

                if (response == "N")
                {
                    continueInput = false;
                }
                else if (response != "Y")
                {
                    Console.WriteLine("Invalid input. Enter Y to continue or N to exit.");
                }
            }
        }

        static void printNumbers(IEnumerable<int> numbers) // any IEnumerable making the code more modular
        {
            if (!numbers.Any()) // LINQ to check if the collection is empty
            {
                Console.WriteLine("No numbers were entered.");
            }
            else
            {
                Console.WriteLine("Numbers entered (by order of input):");
                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}