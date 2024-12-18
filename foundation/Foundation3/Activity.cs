using System;
public abstract class Activity
{
    protected DateTime Date { get; set; }
    protected int Duration { get; set; }  
    public Activity(DateTime date, int duration)
    {
        Date = date;
        Duration = duration;
    }
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public string GetSummary()
    {
        string distanceUnit = "miles"; 
        string speedUnit = "mph"; 
        string paceUnit = "min per mile"; 
        return $"{Date.ToString("dd MMM yyyy")} {GetType().Name} ({Duration} min) - Distance {GetDistance():0.0} {distanceUnit}, Speed {GetSpeed():0.0} {speedUnit}, Pace: {GetPace():0.0} {paceUnit}";
    }
}
