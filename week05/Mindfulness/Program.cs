using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflection Exercise");
            Console.WriteLine("3. Listing Exercise");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an activity: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    BreathingExercise();
                    break;
                case "2":
                    ReflectionExercise();
                    break;
                case "3":
                    ListingExercise();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void BreathingExercise()
    {
        Console.Clear();
        Console.WriteLine("Breathing Exercise: Focus on your breath.");
        Console.Write("Enter duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        for (int i = 0; i < duration / 4; i++)
        {
            Console.WriteLine("Inhale...");
            Thread.Sleep(2000);
            Console.WriteLine("Hold...");
            Thread.Sleep(1000);
            Console.WriteLine("Exhale...");
            Thread.Sleep(2000);
        }
        Console.WriteLine("Well done! Press Enter to return to the menu.");
        Console.ReadLine();
    }

    static void ReflectionExercise()
    {
        Console.Clear();
        Console.WriteLine("Reflection Exercise: Think about a positive experience.");
        Console.Write("Enter duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        List<string> prompts = new List<string>
        {
            "Think of a time you felt truly happy.",
            "Recall a moment when you helped someone.",
            "What is something you are grateful for today?"
        };

        Random rand = new Random();
        for (int i = 0; i < duration / 5; i++)
        {
            Console.WriteLine(prompts[rand.Next(prompts.Count)]);
            Thread.Sleep(5000);
        }
        Console.WriteLine("Great job! Press Enter to return to the menu.");
        Console.ReadLine();
    }

    static void ListingExercise()
    {
        Console.Clear();
        Console.WriteLine("Listing Exercise: Write down things you appreciate.");
        Console.Write("Enter duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Start listing now:");

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        List<string> items = new List<string>();
        while (DateTime.Now < endTime)
        {
            Console.Write("- ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine("Well done! You listed:");
        foreach (var item in items)
        {
            Console.WriteLine("- " + item);
        }
        Console.WriteLine("Press Enter to return to the menu.");
        Console.ReadLine();
    }
}
