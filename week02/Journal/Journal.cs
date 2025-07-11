using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText}\n {entry._entryText}\n");
        };
    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"Date,Prompt,Entry");
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry._date,entry._promptText,entry._entryText);
            }
        }
    }

    public void LoadFromFile(string file)
    {
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            
        }
    }
}