using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 運動データのリスト
        List<Exercise> exercises = new List<Exercise>
        {
            new Running("2024-02-20", 30, 5.0), 
            new Cycling("2024-02-21", 60, 20.0),
            new Swimming("2024-02-22", 45, 30) 
        };

        Console.WriteLine("Exercise Tracking Results:\n");

        foreach (var exercise in exercises)
        {
            exercise.DisplaySummary(); // 運動の概要を表示
            Console.WriteLine(); // 見やすくするため改行を追加
        }

    }
}
