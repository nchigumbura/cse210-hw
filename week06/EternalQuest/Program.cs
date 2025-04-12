using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        ScoreTracker scoreTracker = new ScoreTracker();

        while (true)
        {
            Console.WriteLine("\nEternal Quest Menu");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    foreach (var goal in goals)
                    {
                        Console.WriteLine(goal.DisplayGoal());
                    }
                    break;
                case 4:
                    scoreTracker.DisplayScore();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
