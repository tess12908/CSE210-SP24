public class Simple : Goals
{

    public Simple(string _name, string _description, string _score)
       : base(_name, _description, _score)
    {
        
    }

    public string GetSimpleTitle()
    {
        return _name;
    }
    public string GetSimpleDescription()
    {
        return _description;
    }

    public int GetSimplePoints()
    {
        return _score;
    }
    public override string SaveToFile()
    {
        return $" {_isComplete} | {_name} | {_description} | {_score} ";

    }
    
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            //score += _points;
            Console.WriteLine($"Goal '{_name}' completed! You earned {_score} points.");
            return _score; 
        }
        else
        {
            Console.WriteLine($"Goal '{_name}' is already completed.");
            return 0; 
        }
    }

    public override void Display()
    {
        string status = "[]";
        
        if (_isComplete == true)
        { 
            status = "[x]";
            Console.WriteLine($"{status} {_name} - {_description}");
        } 
        else if (_isComplete == false)
        { 
            status = "[]";
            Console.WriteLine($"{status} {_name} - {_description}");

        }

    }
    

}