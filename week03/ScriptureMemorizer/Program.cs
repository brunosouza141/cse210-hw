using System;
using System.IO.Enumeration;
using System.Net.Quic;
using System.Runtime.CompilerServices;
using System.Text.Json.Nodes;
using System.Timers;

class Program
{
    // Philippians 1:23-24
    // For I am in a strait betwixt two, having a desire to depart, and to be with Christ; which is far better: Nevertheless to abide in the flesh is more needful for you.
    static void Main(string[] args)
    {
        Random random = new Random();
        string quit;
        int RunNumber;
        List<int> usedIndex = new List<int>();
        Console.WriteLine("Do you want to load the scriptures from a csv file? Please insert the file path. \nPress enter to skip.");
        string filename = Console.ReadLine();
        // string scriptureText = "For I am in a strait betwixt two, having a desire to depart, and to be with Christ; which is far better: Nevertheless to abide in the flesh is more needful for you.";
        LoadScriptures getScriptureData = new LoadScriptures(filename);
        string[] referenceArray = getScriptureData.getReference();

        string scriptureText = getScriptureData.getScriptureText();
        Console.WriteLine(scriptureText);
        Reference reference;
        if (referenceArray.Length == 4)
        {
            reference = new Reference(referenceArray[0], int.Parse(referenceArray[1]), int.Parse(referenceArray[2]), int.Parse(referenceArray[3]));
        }
        else if (referenceArray.Length == 3)
        {
            reference = new Reference(referenceArray[0], int.Parse(referenceArray[1]), int.Parse(referenceArray[2]));

        }
        else
        {
            reference = null;
        }
        
        Scripture scripture = new Scripture(reference,scriptureText);
        do
        {
            
            Console.Clear();
            Console.Write(reference.GetDisplayText() + " ");
            Console.WriteLine(scripture.GetDisplayText() + "\n");

            if (scripture.IsCompletelyHidden() == true)
            {
                break;
            }

            //I need to make sure we will not try to hide the same word.
            //So, I add a index to a list everytime I use so I can exclude in case.
            do
            {
                RunNumber = random.Next(scriptureText.Split(" ").Length);
            } while (usedIndex.Contains(RunNumber));
            usedIndex.Add(RunNumber);

            scripture.HideRandomWords(RunNumber);

            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            quit = Console.ReadLine();

        } while (quit != "quit");
    }
}