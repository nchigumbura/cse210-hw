using System;
using System.Collections.Generic;

public class ListingActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
    {
        activityName = "Listing";
        activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public override void RunActivity()
    {
        StartMessage();

        Random random = new Random();
        Console.WriteLine("\n" + prompts[random.Next(prompts.Count)]);
        SpinningAnimation(3);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int itemCount = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("\nEnter an item: ");
            Console.ReadLine();
            itemCount++;
            SpinningAnimation(1);
        }

        Console.WriteLine($"\nYou listed {itemCount} items!");
        EndMessage();
    }
}
