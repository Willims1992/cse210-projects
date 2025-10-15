using System;
using System.Threading;

public class VisualizationActivity : Activity
{
    public VisualizationActivity() : base("Visualization", "This activity helps you visualize a peaceful place and mentally relax.") { }

    protected override void Run()
    {
        string[] scenes = {
            "Imagine you're walking through a quiet forest...",
            "Picture yourself lying on a warm beach...",
            "Visualize floating gently on a calm lake...",
            "See yourself in a cozy cabin with a crackling fire..."
        };

        DateTime endTime = DateTime.Now.AddSeconds(Duration);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(scenes[i % scenes.Length]);
            Spinner(5);
            i++;
        }
    }
}
