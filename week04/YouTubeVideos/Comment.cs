using System;


public class Comment
{
    private string _name;
    private string _commentText;
    public Comment(string name, string commentText)
    {
        _name = name;
        _commentText = commentText;
    }
    public void DisplayComment()
    {
        Console.WriteLine("Name: " + _name);
        Console.WriteLine("Comment: " + _commentText + "\n");
    }
}