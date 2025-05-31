using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text, bool isHidden) // constructor 
    {
        _text = text;
        _isHidden = isHidden;
    }

    public bool GetIsHiddenChecker() // checks if it is hidden 
    {
        return _isHidden;
    }

    public void Hide() // returns _isHidden as true to hide the word when this is called
    {
        _isHidden = true;
    }

    public string GetText() // seperates the word into letters to replace the letter with _ but if it not the word to be hidden it just returns the word as is
    {
        if (_isHidden)
        {
            string replaced = "";
            for (int i = 0; i < _text.Length; i++)
            {
                replaced += "_";
            }
            return replaced;
        }
        else
        {
            return _text;
        }
    }
    
}

