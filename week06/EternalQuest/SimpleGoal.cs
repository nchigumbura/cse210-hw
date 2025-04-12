public class SimpleGoal : Goal
{
    private bool IsComplete;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        IsComplete = false;
    }

    public override void RecordEvent()
    {
        IsComplete = true;
    }

    public override string DisplayGoal()
    {
        return $"{Name} [ {(IsComplete ? "X" : " ")} ] - {Points} points";
    }
}
