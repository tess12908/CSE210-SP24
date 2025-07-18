abstract class Activity
{
    protected string _date;
    protected int _duration; 

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

     public int GetDuration()
    {
        return _duration;
    }

    public string GetDate()
    {
        return _date;
    }

    public virtual string GetActivityName() // cahneg the name in the other classes
    {
        return ""; 
    }
    
    public virtual double GetDistance() // overide in other classes
    {
        return 0;
    }
    public virtual double GetSpeed() // overide in other classes
    { 
        return 0; 
    }
    public virtual double GetPace() // overide in other classes
    { 
        return 0; 
    }

    public virtual string GetSummary() // set as a standared that can be changed later if needed
    {
        return $"{_date}\n{GetActivityName()} ({_duration} min)\nDistance: {GetDistance():F2} miles\nSpeed: {GetSpeed():F2} MPH\nPace: {GetPace():F2} min per mile";
    }
}
