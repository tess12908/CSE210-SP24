public class Checklist : Goals
{
    private int _timesCompleted = 0;
    private int _targetCount;
    private int _bonus;

    public Checklist(int targetCount, int bonus, string _score, string _name, string _description) : base( _name, _description, _score)
    { 
        this._targetCount = targetCount;
        this._bonus = bonus;
    }

    public string GetCheckListTitle()
    {
        return _name;
    }
    public string GetCheckListDescription()
    {
        return _description;
    }


    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }

    public int GetTargetCount()
    {
        return _targetCount;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public int GetCheckListPoints()
    {
        return _score;
    }
        
    public override int RecordEvent()
    {
        _timesCompleted++;

        if (_timesCompleted >= _targetCount)
        {
            _isComplete = true;
            Console.WriteLine($"Goal '{_name}' completed! You earned a bonus of {_bonus} points.");
            return _score +_bonus;

        }
        return _score; 
    }

     public override string SaveToFile()
    { 
        // specifiy what the type is 
        return $" {_isComplete} | {_name} | {_description} | {_timesCompleted} | {_targetCount} | {_bonus} "; 
        
    }


    public override void Display()
    {
        string status = $"Completed {_timesCompleted}/{_targetCount}";
        Console.WriteLine($"{status} {_name} - {_description}");
        
    }
    
}