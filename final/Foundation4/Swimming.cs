class Swimming : Activity
{
    private int _laps;
    private double _lapDistance = (50.0 / 1000.0) * 0.62;

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }

     public override double GetDistance()
    {
        double swimDistance = _laps * _lapDistance;
        return swimDistance; 
    }

    public override double GetSpeed()
    {
        double swimSpeed = GetDistance() / (GetDuration() / 60.0);
        return swimSpeed; 
    }
    
    public override string GetActivityName()
    {
        return "Swimming"; 
    }

    public override double GetPace()
    {
        double swimPace = GetDuration() / GetDistance();
        return swimPace;
    }

} 