using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference; // Scripture reference
    private List<Word> _words; // List of words in the scripture

    // Split the scripture text into words and create Word objects
    public Scripture(string reference, string text)
    {
        _reference = new Reference(reference);
        _words = new List<Word>();
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    // Hide one random word from the scripture text
    public void HideRandomWords()
    {
        Random random = new Random();
        foreach (Word word in _words)
        {
            if (!word.IsHidden)
            {
                word.Hide(); // Replace the word with underscores
                break; // Stop after hiding one word
            }
        }
    }

    // Reveal one hidden word for hints
    public void RevealHint()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden)
            {
                word.Unhide(); // Show the word
                break; // Stop after revealing one word
            }
        }
    }

    // Check if all words in the scripture are hidden
    public bool IsFullyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden)
                return false; // If any word is visible, return false
        }
        return true;
    }

    // Display the scripture with hidden words and the reference
    public string Display()
    {
        string scriptureText = _reference.GetFormattedReference() + "\n";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return scriptureText.Trim();
    }
}
