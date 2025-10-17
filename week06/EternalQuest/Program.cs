using System;
/*
CREATIVE FEATURES ADDED TO EXCEED REQUIREMENTS:

1. Leveling System:
   * Users level up every 1000 points.
   * Current level is displayed with the score.
   *  Celebratory message appears when leveling up.

2. Negative Goals:
   * New goal type that deducts points when recorded.
   * Helps discourage bad habits (e.g., "Skipped scripture study").
   * Displayed with a  symbol in the goal list.

These features enhance motivation and accountability, making the Eternal Quest more engaging and fun!
*/


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
         GoalManager manager = new GoalManager();
        string filename = "goals.txt";

        while (true)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1": manager.CreateGoal(); break;
                case "2": manager.RecordEvent(); break;
                case "3": manager.ShowGoals(); break;
                case "4": manager.ShowScore(); break;
                case "5": manager.Save(filename); break;
                case "6": manager.Load(filename); break;
                case "7": return;
            }
        }
    }
}