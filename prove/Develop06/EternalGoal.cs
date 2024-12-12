public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) 
        : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Increment the points without marking as complete
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetDetailsString()
    {
        return $"Eternal Goal: {_shortName} - {_description} ({_points} points per event)";
    }

    public override string GetStringRepresentation()
    {
        return $"[EternalGoal] {_shortName}: Ongoing";
    }
}