class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) :  base(name, description, points)
    {}

    public override void CompleteGoal()
    {
        if (!_isComplete)
        {
            _isComplete = true;
        }
    }

    public override int CalculatePoints()
    {
        return _points;
    }

    public override string GetStatusString()
    {
        return $"{(_isComplete ? "[X]" : "[ ]")} {_name} ({_description})";
    }

    public override string SaveGoal()
    {
        return $"Simple Goal|{_name}|{_description}|{_points}|{_isComplete}";
    }
}