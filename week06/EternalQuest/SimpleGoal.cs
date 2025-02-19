class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"✅ Goal '{Name}' completed! +{Points} points");
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetails()
    {
        return $"{Name} ({Points} points) - Completed: {_isComplete}";
    }
}
