using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected DateTime _endTime;

    public Activity()
    {
        _name = "Reflecting";
        _description = "This activity will help you to reflext on times ...";
        _duration = 50;
    }

    public void SetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        _endTime = DateTime.Now.AddSeconds(_duration);
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine(_description + "\n");
        SetDuration();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds)
    {
        Thread.Sleep(seconds * 1000);
        Console.WriteLine(); 
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write(i);          
            Thread.Sleep(1000);        

            
            Console.Write("\b \b");
        }

        Console.WriteLine("\n"); 
    }
}