using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private string[] prompts = {
        "Who was the most interesting person you met today?",
        "What was the best part of your day?",
        "How did you see the hand of the Lord in your life today?",
        "What was the strongest emotion you felt today?",
        "If you could do one thing over today, what would it be?"
    };

    public void AddEntry()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Length)];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        entries.Add(new Entry(prompt, response));
        Console.WriteLine("✅ Entry added successfully!");
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("📖 No entries available.");
            return;
        }
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry);
            }
        }
        Console.WriteLine($"✅ Journal saved to {filename}!");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("⚠️ File not found.");
            return;
        }

        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(" | ");
            if (parts.Length == 3)
            {
                entries.Add(new Entry(parts[1], parts[2]));
            }
        }
        Console.WriteLine($"✅ Journal loaded from {filename}!");
    }
}
