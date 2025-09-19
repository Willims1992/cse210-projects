using System;

public class Entry
{
    // REQUIRED: date, prompt, response
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    // EXCEED REQUIREMENT: mood rating (extra info)
    public int Mood { get; set; }

    // Constructor (runs when you make a new Entry)
    public Entry(string prompt, string response, int mood)
    {
        Date = DateTime.Now.ToShortDateString(); // today's date
        Prompt = prompt;
        Response = response;
        Mood = mood;
    }

    // Show the entry nicely on screen
    public string GetDisplay()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\nMood: {Mood}/10\n";
    }

    // Save to file (make it one line)
    public string GetSaveFormat()
    {
        return $"{Date}|{Prompt}|{Response}|{Mood}";
    }

    // Load entry back from file text
    public static Entry FromSaveFormat(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length == 4)
        {
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            int mood = int.Parse(parts[3]);

            // Make new entry with data
            Entry entry = new Entry(prompt, response, mood);
            entry.Date = date; // keep saved date
            return entry;
        }
        else
        {
            return null;
        }
    }
}
