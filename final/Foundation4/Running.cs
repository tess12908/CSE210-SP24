class Running : Activity
{
    private double _distance;
    //private List<Running> _runningPace = new List<Running>();

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double runningspeed = _distance / (GetDuration() / 60.0);
        return runningspeed; 
    }
    
    public override string GetActivityName()
    {
        return "Running"; 
    }

    public override double GetPace()
    {
        double runningPace = this.GetDuration() / this._distance;
        //_runningPace.Add(runningPace);
        return runningPace;
    }
}