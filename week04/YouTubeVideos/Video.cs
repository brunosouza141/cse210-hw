using System;
using System.Net;
using System.Reflection;


public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int NumberOfComments()
    {
        return _comments.Count();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"{_title}\n{_author}\n{_length / 60} minutes");
        Console.WriteLine(NumberOfComments() + " comments\n");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }
}