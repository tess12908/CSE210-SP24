public class Eternal : Goals
{
       
     
    public Eternal(string _score, string _name, string _description) : base( _name, _description, _score)
    {
        
    }

    public string GetEternalTitle()
    { 
        return _name; 
    }
    public string GetEternalDescription()
    { 
        return _description; 
    }

    public int GetEternalPoints()
    { 
        return _score; 
    }

    
    public override int RecordEvent()
    {
        Console.WriteLine($"You earned {_score} points for repeating '{_name}'.");
        return _score; 
    }
    
     public override string SaveToFile()
    { 
        return $" {_isComplete} | {_name} | {_description} | {_score} " ; 
        
    }

    public override void Display()
    {
        string status = "[ ]";
        Console.WriteLine($"{status} {_name} - {_description}");
    }
} 
