using System;
using System.Collections.Generic;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("\n🎯 Goal Tracker Menu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Show goals");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    ShowGoals();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("❌ Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter points for completion: ");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string type = Console.ReadLine();

        Goal newGoal = null;
        switch (type)
        {
            case "1":
                newGoal = new SimpleGoal(name, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, points);
                break;
            case "3":
                Console.Write("Enter target count for completion: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                newGoal = new ChecklistGoal(name, points, targetCount, bonusPoints);
                break;
            default:
                Console.WriteLine("❌ Invalid choice.");
                return;
        }

        _goals.Add(newGoal);
        Console.WriteLine($"✅ Goal '{name}' added!");
    }

    private void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("❌ No goals available.");
            return;
        }

        Console.WriteLine("\n🏆 Select a goal to record progress:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetails()}");
        }
        Console.Write("Enter goal number: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            _goals[choice].RecordEvent();
        }
        else
        {
            Console.WriteLine("❌ Invalid selection.");
        }
    }

    private void ShowGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("❌ No goals have been created.");
            return;
        }

        Console.WriteLine("\n📋 Current Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetails());
        }
    }
}
