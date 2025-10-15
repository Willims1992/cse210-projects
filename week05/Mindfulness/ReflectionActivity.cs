using System;
using System.Collections.Generic;
using System.Threading;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind?"
    };

    public ReflectionActivity() : base("Reflection", "This activity helps you reflect on times of strength and resilience.") { }

    protected override void Run()
    {
        Console.WriteLine(_prompts[new Random().Next(_prompts.Count)]);
        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        var used = new HashSet<int>();

        while (DateTime.Now < endTime)
        {
            int index;
            do { index = new Random().Next(_questions.Count); } while (used.Contains(index));
            used.Add(index);

            Console.WriteLine(_questions[index]);
            Spinner(5);

            if (used.Count == _questions.Count) used.Clear();
        }
    }
}
