
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

public class Journal 
{

    public List<Entry> _entryList; 

    public Journal()
    {
       _entryList = new List<Entry>();
    }
    
    public void WriteNewEntry()
    {

        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        Console.WriteLine("What do you want the tittle to be?"); 
        string Title = Console.ReadLine(); 

        Prompts EntryPrompt = new Prompts(); 
        string _prompt = EntryPrompt.Show(); 
        Console.WriteLine(_prompt); 
        string UserResponse = Console.ReadLine(); 

        Entry cleanSlate = new Entry(dateText,Title,_prompt, UserResponse); 
        _entryList.Add(cleanSlate); 
    
    }

    public void AddFromFile(string _entryDate, string _entryTitle, string _entryPrompt, string _entryResponce)
    {
        Entry cleanSlate = new Entry(_entryDate,_entryTitle,_entryPrompt, _entryResponce); 
        _entryList.Add(cleanSlate); 
    }

    public void Display()
    { 
        foreach(Entry i in _entryList)
        { 
            Console.WriteLine(i.EntryDisplay()); 
        }
    }

    public string ReturnListOfEntry()
    { 
        string result = ""; 
        foreach(Entry i in _entryList)
        { 
            result = result + i.SaveInfo() + "\n"; 
        }

        return result; 
    }

}