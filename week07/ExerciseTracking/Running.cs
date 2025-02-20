class Running : Exercise
{
    public double Distance { get; set; } 

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        Distance = distance;
    }

    public override double GetDistance() => Distance;
    public override double GetSpeed() => Distance / (Duration / 60.0);
    public override double GetPace() => Duration / Distance;
}
