using System;


public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (string word in text.Split(' ')) 
        {
            _words.Add(new Word(word));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        _words[numberToHide].Hide();
    }
    public string GetDisplayText()
    {
        List<string> result = new List<string>();
        foreach (Word word in _words)
        {
            result.Add(word.GetDisplayText());
        }
        return string.Join(" ", result);
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }

}