using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string fileName = "verses.txt";

        List<Scripture> scriptures = LoadScripturesFromFile(fileName);

        Random random = new Random();
        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        RunMemorizationProgram(scripture);
    }

    static List<Scripture> LoadScripturesFromFile(string verses)
    {
        List<Scripture> scriptures = new List<Scripture>();

        try
        {
            foreach (string line in File.ReadLines(verses))
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2) // Ensure valid format
                {
                    scriptures.Add(new Scripture(parts[0], parts[1]));
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Error: File '{verses}' could not be found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }

        return scriptures;
    }

    // Memorization program logic
    static void RunMemorizationProgram(Scripture scripture)
    {
        int score = 0;

        while (true)
        {
            Console.WriteLine(scripture.Display());
            Console.WriteLine($"Score: {score}\n");

            // Prompt user for action
            Console.WriteLine("Press Enter to continue, type 'hint' for help (-5 points), or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
                break;

            if (userInput.ToLower() == "hint")
            {
                scripture.RevealHint();
                score -= 5;
                continue;
            }

            scripture.HideRandomWords();
            score += 10;

            if (scripture.IsFullyHidden())
            {
                Console.WriteLine(scripture.Display());
                Console.WriteLine($"\nFinal Score: {score}");
                Console.WriteLine("All words hidden. Program ending.");
                break;
            }
        }
    }
}
