class Cycling : Exercise
{
    public double Speed { get; set; } // 速度（km/h）

    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        Speed = speed;
    }

    public override double GetDistance() => Speed * (Duration / 60.0);
    public override double GetSpeed() => Speed;
    public override double GetPace() => 60 / Speed;
}
