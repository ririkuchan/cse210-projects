class Swimming : Exercise
{
    public int Laps { get; set; } 

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        Laps = laps;
    }

    public override double GetDistance() => Laps * 0.025; 
    public override double GetSpeed() => GetDistance() / (Duration / 60.0);
    public override double GetPace() => Duration / GetDistance();
}
