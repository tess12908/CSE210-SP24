public abstract class Goals
{
    protected string _name;
    protected string _description;
    protected int _score;
    protected bool _isComplete;
    public Goals(string name, string des, string score)
    {
        _name = name;
        _description = des;
        _score = int.Parse(score);

    }

    public abstract string SaveToFile(); // ABSTRACT 
    public abstract void Display(); // ABSTRACT 
    public abstract int RecordEvent(); // ABSTRACT 

    // public string GetNameQuestion()
    // {
    //     Console.WriteLine("What is the name of your goal");
    //     string _name = Console.ReadLine();
    //     return _name;
    // }

    // public string GetDescriptionQuestion()
    // {
    //     Console.WriteLine("What is a short description of your goal");
    //     string _description = Console.ReadLine();
    //     return _description;
    // }

    public int GetTheScore()
    { 
        return _score; 
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public bool MarkComplete()
    { 
        return true; 
    }
}