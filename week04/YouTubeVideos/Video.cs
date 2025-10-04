using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        Length = lengthInSeconds;
        Comments = new List<Comment>();
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void DisplayVideoInfo()
    {
        System.Console.WriteLine($"Title: {Title}");
        System.Console.WriteLine($"Author: {Author}");
        System.Console.WriteLine($"Length: {Length} seconds");
        System.Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        System.Console.WriteLine("Comments:");
        foreach (Comment comment in Comments)
        {
            Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
        }
        Console.WriteLine();
    }
}
