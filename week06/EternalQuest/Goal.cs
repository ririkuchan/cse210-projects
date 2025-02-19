using System;

abstract class Goal
{
    public string Name { get; set; }
    public int Points { get; set; }

    public Goal(string name, int points)
    {
        Name = name;
        Points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetails();
}
