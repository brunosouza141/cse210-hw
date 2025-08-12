using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
        SimpleGoal teste = new SimpleGoal("test", "", "");
        Console.WriteLine(teste.test(teste));
    }

    
}