public class Running : Activity
{
    private double distance; // in kilometers

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        this.distance = distance;
    }

    public override double GetDistance() => distance;

    public override double GetSpeed() => (GetDistance() / GetDuration()) * 60;

    public override double GetPace() => GetDuration() / GetDistance();
}