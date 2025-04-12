public class ChecklistGoal : Goal
{
    private int TimesCompleted;
    private int TargetTimes;
    private int BonusPoints;

    public ChecklistGoal(string name, int points, int targetTimes, int bonusPoints) 
        : base(name, points)
    {
        TimesCompleted = 0;
        TargetTimes = targetTimes;
        BonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        TimesCompleted++;
    }

    public override string DisplayGoal()
    {
        return $"{Name} [Completed {TimesCompleted}/{TargetTimes}] - {Points} points each time, Bonus: {BonusPoints} points when complete";
    }
}
