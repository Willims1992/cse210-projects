using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breath.") { }

    protected override void Run()
    {
        int elapsed = 0;
        while (elapsed < Duration)
        {
            Console.WriteLine("Breathe in...");
            BreathingAnimation(4);
            elapsed += 4;
            if (elapsed >= Duration) break;

            Console.WriteLine("Breathe out...");
            BreathingAnimation(4);
            elapsed += 4;
        }
    }

    private void BreathingAnimation(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(new string('■', i + 1));
            Thread.Sleep(1000);
            Console.Write("\r" + new string(' ', i + 1) + "\r");
        }
    }
}
