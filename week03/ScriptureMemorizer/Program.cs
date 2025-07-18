using System;
using System.Net.Quic;
using System.Runtime.CompilerServices;

class Program
{
    // Philippians 1:23-24
    // For I am in a strait betwixt two, having a desire to depart, and to be with Christ; which is far better: Nevertheless to abide in the flesh is more needful for you.
    static void Main(string[] args)
    {
        Random random = new Random();
        Reference reference = new Reference("Philippians", 1, 23, 24);
        string scriptureText = "For I am in a strait betwixt two, having a desire to depart, and to be with Christ; which is far better: Nevertheless to abide in the flesh is more needful for you.";
        string quit;
        int number;
        List<int> usedIndex = new List<int>();

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
                number = random.Next(scriptureText.Split(" ").Length);
            } while (usedIndex.Contains(number));
            usedIndex.Add(number);

            scripture.HideRandomWords(number);

            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            quit = Console.ReadLine();

        } while (quit != "quit");
    }
}