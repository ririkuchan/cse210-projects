using System;

abstract class Exercise
{
    public string Date { get; set; }
    public int Duration { get; set; } // 運動時間（分）

    public Exercise(string date, int duration)
    {
        Date = date;
        Duration = duration;
    }

    // 抽象メソッド（派生クラスで実装）
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // 共通の表示メソッド
    public virtual void DisplaySummary()
    {
        Console.WriteLine($"📅 Date: {Date} | ⏳ Duration: {Duration} min");
        Console.WriteLine($"🚀 Distance: {GetDistance()} km | 🏃 Speed: {GetSpeed()} km/h | ⏱️ Pace: {GetPace()} min/km");
    }
}
