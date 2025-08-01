using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private Random _random = new Random();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;
        _prompts = ["Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you have helped this week?",
                    "When have you felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?"];
    }
    public void Run()
    {

        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        do
        {
            Console.Write("> ");
            Console.ReadLine();
            _count += 1;
        } while (DateTime.Now < _endTime);
        Console.WriteLine($"You listed {_count} items!\n");
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        return "--- " + _prompts[_random.Next(1, _prompts.Count()+1)] + " ---";
    }
    public List<string> GetListFromUser()
    {
        return _prompts;
    }
}