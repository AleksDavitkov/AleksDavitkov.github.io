using homework6.Helpers;
using System.IO;

ConsoleHelper.WriteInColor("\n=== File System & Streams ===\n", ConsoleColor.Blue);

// 01
string filesFolder = @"..\..\..\Files";
string fileName = "names.txt";
string fullFilePath = Path.Combine(filesFolder, fileName);


if (!Directory.Exists(filesFolder))
{
    Directory.CreateDirectory(filesFolder);
    ConsoleHelper.WriteInColor($"{filesFolder} created successfully.", ConsoleColor.DarkGreen);
}
else
{
    ConsoleHelper.WriteInColor($"{filesFolder} already exists.", ConsoleColor.DarkRed);
}

if (!File.Exists(fullFilePath))
{
    File.Create(fullFilePath).Close();
    ConsoleHelper.WriteInColor($"{fullFilePath} created successfully.", ConsoleColor.DarkGreen);
}
else
{
    ConsoleHelper.WriteInColor($"{fullFilePath} already exists.", ConsoleColor.DarkRed);
}

// 02
ConsoleHelper.WriteInColor("Existing names in file:", ConsoleColor.Gray);

if (File.Exists(fullFilePath))
{
    using (StreamReader reader = new StreamReader(fullFilePath))
    {
        string name;
        while ((name = reader.ReadLine()) != null)
        {
            ConsoleHelper.WriteInColor(name, ConsoleColor.Gray);
        }
    }
}
else
{
    ConsoleHelper.WriteInColor("File is empty.", ConsoleColor.Yellow);
}

ConsoleHelper.WriteInColor("\nEnter Names -> write 'ok' when done: \n", ConsoleColor.Gray);

using (StreamWriter writer = new StreamWriter(fullFilePath, append: true))
{
    while (true)
    {
        Console.Write("Name: ");
        string input = Console.ReadLine();

        if (input.ToLower() == "ok")
            break;

        writer.WriteLine(input);
        ConsoleHelper.WriteInColor($"Added: {input}", ConsoleColor.Green);
    }
}

// 03
if (!File.Exists(fullFilePath))
{
    ConsoleHelper.WriteInColor($"File '{fileName}' not found.", ConsoleColor.Red);
    return;
}

List<string> allNames = File.ReadAllLines(fullFilePath)
                            .Select(name => name.Trim())
                            .Where(name => !string.IsNullOrWhiteSpace(name)) // Skip empty entries
                            .ToList();

// Loop through all letters A-Z
for (char letter = 'A'; letter <= 'Z'; letter++)
{
    List<string> startLetterMatch = allNames
        .Where(name => name.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
        .ToList();

    if (startLetterMatch.Count > 0)
    {
        string fileByLetter = $"namesStartingWith_{letter}.txt";
        string letterFilePath = Path.Combine(filesFolder, fileByLetter);

        using (StreamWriter writer = new StreamWriter(letterFilePath))
        {
            foreach (string name in startLetterMatch)
            {
                writer.WriteLine(name);
            }
        }

        ConsoleHelper.WriteInColor($"Created '{fileByLetter}' with {startLetterMatch.Count} names.", ConsoleColor.Green);
    }
}