using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity helps you reflect on the good things in your life.") { }

    protected override void Run()
    {
        Console.WriteLine(_prompts[new Random().Next(_prompts.Count)]);
        Console.WriteLine("Get ready...");
        Countdown(3);
        Console.WriteLine("Start listing! Press Enter after each item.");

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        int count = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
    }
}
