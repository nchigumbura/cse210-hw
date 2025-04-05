using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("\nChoose an option: ");
            string choice = Console.ReadLine();

            MindfulnessActivity activity;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    activity.RunActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    activity.RunActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    activity.RunActivity();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
