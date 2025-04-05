using System;
using System.Threading;

public class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
    {
        activityName = "Breathing";
        activityDescription = "This activity will help you relax by guiding your breathing. Clear your mind and focus on your breaths.";
    }

    public override void RunActivity()
    {
        StartMessage();

        int secondsPerPhase = 4;
        int totalPhases = duration / secondsPerPhase;

        for (int phase = 0; phase < totalPhases; phase++)
        {
            Console.WriteLine("\nBreathe in...");
            PauseWithCountdown(2);

            Console.WriteLine("Breathe out...");
            PauseWithCountdown(2);
        }

        EndMessage();
    }
}
