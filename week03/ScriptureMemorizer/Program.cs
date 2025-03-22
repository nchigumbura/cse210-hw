using System;

class Program
{
    static void Main(string[] args)
    {
        // Create scripture with reference and text
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world...");

        while (true)
        {
            // Clear the screen and display scripture
            //Console.Clear();
            Console.WriteLine(scripture.Display());

            // Ask user for input
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            // End program if user types quit
            if (userInput.ToLower() == "quit")
                break;

            // Hide random words in scripture
            scripture.HideRandomWords();

            // Check if all words are hidden
            if (scripture.IsFullyHidden())
            {
                //Console.Clear();
                Console.WriteLine(scripture.Display());
                Console.WriteLine("\nAll words hidden. Program ending.");
                break;
            }
        }
    }
}
