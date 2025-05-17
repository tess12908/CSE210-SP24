public class Entry
{
    public string _userAnswer;  
    public string  _responseDate;  
    public string _question; 
    public string _entryTitle;

     public Entry(string ans, string date, string question, string title)
     {
          _responseDate = date;
          _entryTitle = title;
          _question = question;
          _userAnswer = ans;

    }

    public string EntryDisplay() 
   { 
        return $"Date:{_responseDate}Title: {_entryTitle}Prompt: {_question}Entry: {_userAnswer}"; 
   } 

   public string SaveInfo() 
   { 
        return $"{_responseDate}~{_entryTitle}~{_question}~{_userAnswer}"; 
   } 
}