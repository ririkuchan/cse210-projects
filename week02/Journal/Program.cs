using System;

class Program
{
    static void Main(string[] args)
    {
        static void Main()
    {
        Journal journal = new Journal();
        string filename = "journal.txt";

        while (true)
        {
            Console.WriteLine("\n📒 Journal Menu");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Save to File");
            Console.WriteLine("4. Load from File");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option (1-5): ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.AddEntry();
            }
            else if (choice == "2")
            {
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                journal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                journal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("👋 Exiting program.");
                break;
            }
            else
            {
                Console.WriteLine("⚠️ Invalid choice. Please try again.");
            }
        }
    }
    }
}