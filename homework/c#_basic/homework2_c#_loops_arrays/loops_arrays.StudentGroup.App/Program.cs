namespace loops_arrays.StudentGroup.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG3 = { "Aleks", "Bojan", "Viktor", "Kaja", "Ana" };

            Console.WriteLine("Enter student group - (1 or 3):");
            string input = Console.ReadLine();

            PrintStudents(input, studentsG1, studentsG3);
        }

        // Input validation
        static void PrintStudents(string input, string[] studentsG1, string[] studentsG3)
        {
            if (input == "1")
            {
                ShowGroup("G1", studentsG1);
            }
            else if (input == "3")
            {
                ShowGroup("G3", studentsG3);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 1 or 3.");
            }
        }

        static void ShowGroup(string groupName, string[] students)
        {
            Console.WriteLine($"The Students in {groupName} are:");
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
