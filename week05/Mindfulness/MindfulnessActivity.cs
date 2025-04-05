using System;
using System.Threading;
using System.Collections.Generic;

public abstract class MindfulnessActivity
{
    protected string activityName;
    protected string activityDescription;
    protected int duration;

    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {activityName} Activity!");
        Console.WriteLine(activityDescription);
        Console.Write("\nEnter the duration of the activity in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nPrepare to begin...");
        SpinningAnimation(3);
    }

    public void EndMessage()
    {
        Console.WriteLine("\nGreat job! You've completed the activity.");
        Console.WriteLine($"You spent {duration} seconds in the {activityName} Activity.");
        SpinningAnimation(3);
    }

    protected void SpinningAnimation(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\" };

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i]); 
            Thread.Sleep(500); 
            Console.Write("\b \b"); 
            
            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }

        Console.WriteLine();
    }

    protected void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i); 
            Thread.Sleep(1000); 
            Console.Write("\b \b");
        }
    }

    public abstract void RunActivity();
}
