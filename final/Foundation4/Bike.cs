using System.IO.Pipes;

class Bike : Activity
{
    private double _speed;

    public Bike(string date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        double bikedistance = _speed * (GetDuration() / 60.0);
        return bikedistance;
    }

    public override double GetPace()
    {
        double bikepace = 60.0 / _speed;
        return bikepace;
    }
    
     public override string GetActivityName()
    {
        return "Bike"; 
    }
}