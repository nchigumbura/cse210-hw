public class Cycling : Activity
{
    private double speed; // in kilometers per hour

    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        this.speed = speed;
    }

    public override double GetDistance() => (speed * GetDuration()) / 60;

    public override double GetSpeed() => speed;

    public override double GetPace() => 60 / speed;
}
