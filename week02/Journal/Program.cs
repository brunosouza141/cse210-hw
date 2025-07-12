using System;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = 0;

        //Instanciate the classes
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        //First interaction with the user
        Console.WriteLine("Welcome to the Journal program");
        //Do while the user choose the option 5 (Quit)
        do
        {
            Entry entry = new Entry();
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do: ");
            userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    // Get date as string
                    DateTime theCurrentTime = DateTime.Now;
                    string dateText = theCurrentTime.ToShortDateString();
                    string timeText = theCurrentTime.ToShortTimeString();

                    // Get random prompt and show the user
                    string randomPrompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(randomPrompt);

                    // Add entry details to the Entry instance.
                    Console.Write("> ");
                    entry._entryText = Console.ReadLine();
                    entry._promptText = randomPrompt;
                    entry._date = dateText;
                    entry._time = timeText;

                    journal.AddEntry(entry);


                    break;

                case 2:
                    journal.DisplayAll();
                    break;

                case 3:
                    Console.WriteLine("What is the filename? ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;

                case 4:
                    Console.WriteLine("What is the filename? ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("-----\nInvalid option. Please pick a number between 1 to 5.\n-----");
                    break;

            }
        } while (userChoice != 5);

    }
    
}
