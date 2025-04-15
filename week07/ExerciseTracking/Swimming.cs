public class Swimming : Activity
{
    private int laps;

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        this.laps = laps;
    }

    public override double GetDistance() => laps * 50 / 1000.0;

    public override double GetSpeed() => (GetDistance() / GetDuration()) * 60;

    public override double GetPace() => GetDuration() / GetDistance();
}
