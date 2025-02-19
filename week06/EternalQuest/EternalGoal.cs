class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) {}

    public override void RecordEvent()
    {
        Console.WriteLine($"✅ Progress made on '{Name}'! +{Points} points");
    }

    public override bool IsComplete()
    {
        return false; // 永続的なゴールなので完了しない
    }

    public override string GetDetails()
    {
        return $"{Name} ({Points} points) - Ongoing";
    }
}
