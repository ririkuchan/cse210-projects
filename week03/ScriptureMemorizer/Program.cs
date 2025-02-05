using System;

class Program
{
    static void Main(string[] args)
    {
        Reference ref1 = new Reference("John", 3, 16);
        string verseText = "For God so loved the world that he gave his only begotten Son";
        Scripture scripture = new Scripture(ref1, verseText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit: ");

            string userInput = Console.ReadLine()?.ToLower();
            if (userInput == "quit")
                break;

            scripture.HideRandomWords(2);

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are hidden! Program ending.");
                break;
            }
        }
    }
}