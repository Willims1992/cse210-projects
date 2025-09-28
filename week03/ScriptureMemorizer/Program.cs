using System;
using System.Collections.Generic;

// Exceeding Requirements:
// 1. Multiple scriptures stored in a library and selected randomly.
// 2. Difficulty levels: Easy (1 word), Medium (3), Hard (5).
// 3. Smart hiding: only hides words not already hidden.
// 4. Future support for loading scriptures from external file.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizer!");

        var scriptures = new List<Scripture>
        {
            new Scripture(new Reference("John", 3, 16),
                "For God so loved the world that he gave his one and only Son, " +
                "that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. " +
                "In all thy ways acknowledge him, and he shall direct thy paths.")
        };

        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        Console.WriteLine("Choose difficulty: 1=Easy, 2=Medium, 3=Hard");
        int difficulty = int.TryParse(Console.ReadLine(), out int level) ? level : 1;
        int hideCount = difficulty == 1 ? 1 : difficulty == 2 ? 3 : 5;

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress ENTER to continue or type 'quit' to exit.");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords(hideCount);

            if (scripture.IsCompletelyHidden)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words hidden. Program ended.");
                break;
            }
        }
    }
}
