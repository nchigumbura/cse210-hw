using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference; // Reference of the scripture
    private List<Word> _words; // List of words

    // Constructor to split text into words
    public Scripture(string reference, string text)
    {
        _reference = new Reference(reference);
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    // Hide random words
    public void HideRandomWords()
    {
        Random random = new Random();
        foreach (Word word in _words)
        {
            if (!word.IsHidden)
            {
                word.Hide();
                break; // Stop after hiding one word
            }
        }
    }

    // Check if all words are hidden
    public bool IsFullyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden)
                return false; // If any word is visible, return false
        }
        return true;
    }

    // Display scripture with hidden words
    public string Display()
    {
        string scriptureText = _reference.GetFormattedReference() + "\n"; // Include reference
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return scriptureText.Trim();
    }
}
