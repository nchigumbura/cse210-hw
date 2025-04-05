using System;
using System.Collections.Generic;

public class ReflectionActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?",
        "How can you apply this lesson to your future?"
    };

    public ReflectionActivity()
    {
        activityName = "Reflection";
        activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
    }

    public override void RunActivity()
    {
        StartMessage();

        Random random = new Random();
        Console.WriteLine("\n" + prompts[random.Next(prompts.Count)]);
        SpinningAnimation(3);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\n" + questions[random.Next(questions.Count)]);
            SpinningAnimation(3);
        }

        EndMessage();
    }
}
