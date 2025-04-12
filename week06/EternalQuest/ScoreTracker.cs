public class ScoreTracker
{
    public int TotalScore { get; private set; }

    public void AddPoints(int points)
    {
        TotalScore += points;
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {TotalScore}");
    }
}
