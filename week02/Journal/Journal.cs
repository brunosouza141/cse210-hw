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
            Console.WriteLine($"Date: {entry._date} - Time: {entry._time} - Prompt: {entry._promptText}\n {entry._entryText}\n");
        };
    }

    public void SaveToFile(string file)
    {

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine($"Date,Time,Prompt,Entry");
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._time},{entry._promptText},{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines.Skip(1))
        {
            Entry entry = new Entry();
            string[] splitedLine = line.Split(",");
            entry._date = splitedLine[0];
            entry._time = splitedLine[1];
            entry._promptText = splitedLine[2];
            entry._entryText = splitedLine[3];
            _entries.Add(entry);
        }
    }
}