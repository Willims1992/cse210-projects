using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTube Videos Project.");
        // Create videos
        Video video1 = new Video("Wildlife Documentary", "NatureChannel", 1200);
        Video video2 = new Video("Tech Review: Smartwatch X", "GadgetZone", 600);
        Video video3 = new Video("How to Bake Bread", "HomeChef", 900);
        Video video4 = new Video("Workout Routine for Beginners", "FitLife", 750);

        // Add comments to video1
        video1.Comments.Add(new Comment("Alice", "Loved the lion footage!"));
        video1.Comments.Add(new Comment("Bob", "Very informative."));
        video1.Comments.Add(new Comment("Charlie", "Great narration."));
        video1.Comments.Add(new Comment("Diana", "I want to visit Africa now."));

        // Add comments to video2
        video2.Comments.Add(new Comment("Eve", "Helpful review."));
        video2.Comments.Add(new Comment("Frank", "I bought it after watching."));
        video2.Comments.Add(new Comment("Grace", "Can you compare it with Smartwatch Y?"));

        // Add comments to video3
        video3.Comments.Add(new Comment("Hannah", "My bread turned out perfect!"));
        video3.Comments.Add(new Comment("Ian", "Easy to follow."));
        video3.Comments.Add(new Comment("Jack", "Thanks for the tips."));
        video3.Comments.Add(new Comment("Karen", "Please do sourdough next!"));

        // Add comments to video4
        video4.Comments.Add(new Comment("Leo", "Great for beginners."));
        video4.Comments.Add(new Comment("Mia", "I feel energized."));
        video4.Comments.Add(new Comment("Nina", "Can you do a 30-minute version?"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display video details and comments
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length (seconds): {video.Length}");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}

    
