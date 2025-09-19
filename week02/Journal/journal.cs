using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private Random random = new Random();

    // REQUIRED: list of prompts (for automatic prompt generation)
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What am I most grateful for today?",
        "What’s one small win I achieved today?"
    };

    // REQUIRED: write new entry
    public void WriteNewEntry()
    {
        // pick random prompt
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");

        // get response
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        // EXCEED REQUIREMENT: ask for mood rating
        Console.Write("On a scale of 1–10, how was your mood today? ");
        int mood = int.Parse(Console.ReadLine());

        // make entry
        Entry newEntry = new Entry(prompt, response, mood);
        entries.Add(newEntry);
    }

    // REQUIRED: display entries
    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.GetDisplay());
        }
    }

    // REQUIRED: save to file
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.GetSaveFormat());
            }
        }
    }

    // REQUIRED: load from file
    public void LoadFromFile(string filename)
    {
        entries.Clear(); // remove old entries
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Entry entry = Entry.FromSaveFormat(line);
            if (entry != null)
            {
                entries.Add(entry);
            }
        }
    }
}
