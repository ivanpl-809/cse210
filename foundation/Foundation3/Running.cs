using System;
public class Running : Activity
{
    private double Distance; 
    public Running(DateTime date, int duration, double distance) : base(date, duration)
    {
        Distance = distance;
    }
    public override double GetDistance()
    {
        return Distance;
    }
    public override double GetSpeed()
    {
        return (GetDistance() / Duration) * 60; 
    }
    public override double GetPace()
    {
        return Duration / GetDistance(); 
    }
}
