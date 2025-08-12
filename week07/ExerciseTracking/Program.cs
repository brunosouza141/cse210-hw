using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(5.6, 30);
        Cycling cycling = new Cycling(8.6, 20);
        Swimming swimming = new Swimming(5.7, 10.70, 29);

        Console.WriteLine(running.GetSummary());
        Console.WriteLine(cycling.GetSummary());
        Console.WriteLine(swimming.GetSummary());
    }
}