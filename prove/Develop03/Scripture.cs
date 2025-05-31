using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

class Scripture
{
    Reference _reference;
    string _fullScripture; 
    List<Word> _words = new List<Word>();
    Random rnd = new Random();

    public Scripture(Reference reference, string AllScripture) // constructor
    {
        _reference = reference;
        _fullScripture = AllScripture;
        StrToList(_fullScripture);
    }


    public void StrToList(string fullscripture) // turns the string that is the full scripture into a list of words
    {
        foreach (string word in fullscripture.Split(' '))
        {
            _words.Add(new Word(word, false));
        }
    }

    public int RndNumGen() // makes a random number with a max of the number of words in the full scripture
    {
        int randomNumber = rnd.Next(0, _words.Count);
        return randomNumber; 
    }

    public void HideWords() // uses the rndnumgen to find a index in the list that will then call hide in the word class to change the word to hidden and replace it
    {
        if (IsAllHidden()) // IDEA : for the strech, inside the if ask if the word is aleady hiden and if so find a new number so there is no repeats 
        {
            return;
        }

        bool wordHasBeenHidden = false;

        while (wordHasBeenHidden == false)
        {
            int randomIndex = RndNumGen();
            Word selectedWord = _words[randomIndex];

            if (selectedWord.GetIsHiddenChecker() == false)
            {
                selectedWord.Hide();
                wordHasBeenHidden = true;
            }
        }
    }

    public void DisplayScripture() // show the scripture, _ and all (needs to call all other classes!) 
    {
        Console.Clear();
        Console.WriteLine(_reference.DisplayRef());
        foreach (Word word in _words)
        {
            Console.Write(word.GetText() + " ");
        }
        Console.WriteLine();
    }

    public bool IsAllHidden() // check if all the words are hidden (use this to end the program if true)
    {
        foreach (Word word in _words)
        {
            if (word.GetIsHiddenChecker() == false)
            {
                return false;
            }
        }

        return true;
    }


}