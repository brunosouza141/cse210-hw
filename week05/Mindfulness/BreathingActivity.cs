using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void Run()
    {
        DisplayStartingMessage();
        do
        {
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Thread.Sleep(200);
            Console.Write("Now breathe out...");
            ShowCountDown(5);
            Thread.Sleep(200);
        } while (DateTime.Now < _endTime);
        DisplayEndingMessage();
    }
}