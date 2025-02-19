class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints)
        : base(name, points)
    {
        _timesCompleted = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        _timesCompleted++;
        if (_timesCompleted >= _targetCount)
        {
            Console.WriteLine($"🎉 Goal '{Name}' fully completed! +{_bonusPoints} bonus points");
        }
        else
        {
            Console.WriteLine($"✅ Progress on '{Name}'! +{Points} points ({_timesCompleted}/{_targetCount})");
        }
    }

    public override bool IsComplete()
    {
        return _timesCompleted >= _targetCount;
    }

    public override string GetDetails()
    {
        return $"{Name} ({Points} points per completion, {_bonusPoints} bonus) - Completed {_timesCompleted}/{_targetCount}";
    }
}
