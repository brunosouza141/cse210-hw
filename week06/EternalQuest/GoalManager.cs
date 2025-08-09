using System;
using System.Runtime.InteropServices;
using System.Reflection;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        string option;
        do
        {
            DisplayPlayerInfo();
            Console.WriteLine($"   1. Create New Goal");
            Console.WriteLine($"   2. List Goals");
            Console.WriteLine($"   3. Save Goals");
            Console.WriteLine($"   4. Load Goals");
            Console.WriteLine($"   5. Record Event");
            Console.WriteLine($"   6. Quit");
            Console.Write($"Select a choice from the menu: ");
            option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
            }
        } while (option != "6");

    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points.");
        if (_score < 200)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("You still a beginner, keep going.");
            Console.ResetColor();
            Console.WriteLine("🙂");
            
        }
        else if (_score >= 200 && _score < 400)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Hey, you are getting better. You're a fighter now. ");
            Console.ResetColor();
            Console.WriteLine("🥊");
        }
        else if (_score >= 400 && _score < 800)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("You're no longer only a fighter, but a wizard, wise and strong.");
            Console.ResetColor();
            Console.WriteLine("🧙");
        }
        else if (_score >= 800)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("You should be proud of yourself. Here, take this medal, you are a champion and deseve it!");
            Console.ResetColor();
            Console.WriteLine("🏅");
        }
        Console.WriteLine();

    }
    public void ListGoalNames()
    {
        int counter = 1;
        Console.WriteLine($"The goals are:");
        foreach (Goal goal in _goals)
        {
            string[] splitedGoal = goal.GetStringRepresentation().Split(",");
            Console.WriteLine($"{counter}. {splitedGoal[0]}");
            counter += 1;
        }
    }
    public void ListGoalDetails()
    {
        int counter = 1;
        string completed = " ";
        Console.WriteLine($"The goals are:");
        foreach (Goal goal in _goals)
        {
            string[] goalDetails = goal.GetStringRepresentation().Split(",");
            if (goal.IsCompleted())
            {
                completed = "X";
            }
            if (goalDetails.Count() > 4)
            {
                Console.WriteLine($"{counter}. [{completed}] {goalDetails[0]} ({goalDetails[1]}) -- Currently completed: {goal.GetDetailsString()}/{goalDetails[3]}");
            }
            else
            {
                Console.WriteLine($"{counter}. [{completed}] {goalDetails[0]} ({goalDetails[1]})");
            }
            completed = " ";
            counter += 1;
        }
    }
    public void CreateGoal()
    {
        int target = 0;
        int bonus = 0;
        Console.WriteLine($"The types of Goals are:");
        Console.WriteLine($"   1. Simple Goal");
        Console.WriteLine($"   2. Eternal Goal");
        Console.WriteLine($"   3. Checklist Goal");
        Console.Write($"Which type of goal would you like to create? ");
        string option = Console.ReadLine();
        Console.Write($"What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write($"What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write($"What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();
        if (option == "3")
        {
            Console.Write($"How many times does this goal need to be accomplished for a bonus? ");
            target = int.Parse(Console.ReadLine());
            Console.Write($"What is the bonus for accomplishing it that many times? ");
            bonus = int.Parse(Console.ReadLine());
        }


        switch (option)
            {
                case "1":
                    SimpleGoal simpleGoal = new SimpleGoal(name, description,points);
                    _goals.Add(simpleGoal);
                    break;
                case "2":
                    EternalGoal eternalGoal = new EternalGoal(name, description,points);
                    _goals.Add(eternalGoal);
                    break;
                case "3":
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description,points,target,bonus);
                    _goals.Add(checklistGoal);
                    break;
            }
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string choice = Console.ReadLine();

        _goals[int.Parse(choice) - 1].RecordEvent();
        string[] goalString = _goals[int.Parse(choice) - 1].GetStringRepresentation().Split(",");
        if (goalString.Count() > 4 && _goals[int.Parse(choice) - 1].IsCompleted() == true)
        {
            _score += int.Parse(goalString[2]) + int.Parse(goalString[4]);
            Console.WriteLine($"Congratulations! You have earned {int.Parse(goalString[2]) + int.Parse(goalString[4])} points!");

        }
        else
        {
            _score += int.Parse(goalString[2]);
            Console.WriteLine($"Congratulations! You have earned {goalString[2]} points!");
        }
    }
    public void SaveGoals()
    {
        Console.Write($"What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine($"{goal.GetType().Name}:{goal.GetStringRepresentation()}");
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        foreach (string line in lines.Skip(1))
        {
            string className = line.Split(":")[0];
            string goalFields = line.Split(":")[1];
            string[] goalSplited = goalFields.Split(",");
            switch (className)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(goalSplited[0].ToString(), goalSplited[1].ToString(), goalSplited[2].ToString(),goalSplited[3].ToString()));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(goalSplited[0].ToString(), goalSplited[1].ToString(), goalSplited[2].ToString()));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(goalSplited[0].ToString(), goalSplited[1].ToString(), goalSplited[2].ToString(), int.Parse(goalSplited[3]), int.Parse(goalSplited[4]),int.Parse(goalSplited[5])));
                    break;
            }
        }
    }
}