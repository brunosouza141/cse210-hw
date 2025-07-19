using System;
using System.IO.Enumeration;
using System.Text.Json.Nodes;

public class LoadScriptures
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;
    private string _scriptureText;
    private string _filename;

    public LoadScriptures()
    {



    }

    public LoadScriptures(string filename)
    {
        if (filename == "")
        {
            _filename = "ScripturesList.csv";
        }
        else
        {
            _filename = filename;
        }
        Random random = new Random();

        string[] lines = File.ReadAllLines(_filename);
        int randomLineNumber = random.Next(0, lines.Length);
        string[] csvFields = lines[randomLineNumber].Split("|");

        _book = csvFields[0];
        _chapter = csvFields[1];
        if (csvFields[2].Contains("-"))
        {
            string[] splitedVerse = csvFields[2].Split("-");
            _verse = splitedVerse[0];
            _endVerse = splitedVerse[1];
            
        }
        else
        {
            _verse = csvFields[2];
        }
        _scriptureText = csvFields[3];
        


    }

    public string[] getReference()
    {
        string[] result;
        if (string.IsNullOrEmpty(_endVerse))
        {
            result = new string[] { _book, _chapter, _verse };

        }
        else
        {
            result = new string[] { _book, _chapter, _verse, _endVerse };

        }


        return result;
    }
    public string getScriptureText()
    {
        return _scriptureText;
    }
}