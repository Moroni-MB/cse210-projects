class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) :  base(name, description, points)
    {}

    public override void CompleteGoal()
    {
        // Eternal goals never complete, so do nothing here
    }

    public override int CalculatePoints()
    {
        return _points;
    }

    public override string GetStatusString()
    {
        return ($"[ ] {_name}: ({_description})");
    }
    public override string SaveGoal()
    {
        return $"Eternal Goal|{_name}|{_description}|{_points}";
    }
}