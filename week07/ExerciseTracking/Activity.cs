public abstract class Activity
{
    private string date;
    private int duration; // in minutes

    public Activity(string date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public string GetDate() => date;
    public int GetDuration() => duration;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{date} ({duration} min): Distance {GetDistance()} km, Speed {GetSpeed()} kph, Pace {GetPace()} min per km";
    }
}
