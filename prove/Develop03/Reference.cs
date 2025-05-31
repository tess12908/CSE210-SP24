using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

class Reference
{
    private string _book;
    private string _chapter;
    private int _verseStart;
    private int? _verseEnd;

    public Reference(string book, string chapter, int start) // constructor for scripture that is only 1 verse
    {
        _book = book;
        _chapter = chapter;
        _verseStart = start;
        _verseEnd = null; 
    }
    
    public Reference(string book, string chapter, int start, int end) // constructor for if the scripture is more then 1 verse
    {
        _book = book;
        _chapter = chapter;
        _verseStart = start;
        _verseEnd = end;
    }

    public string DisplayRef() // show the reference 
    {
        if (_verseEnd.HasValue)
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        else
            return $"{_book} {_chapter}:{_verseStart}";
    } 



}
