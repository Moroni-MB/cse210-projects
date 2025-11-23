class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _targetAmount;
    private int _countAmount;
    public ChecklistGoal(string name, string description, int points, int bonusPoints, int targetAmount) :  base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _targetAmount = targetAmount;
        _countAmount = 0;
    }

    public override void CompleteGoal()
    {
        if (_countAmount < _targetAmount)
        {
            _countAmount++;

            if (_countAmount >= _targetAmount)
            {
                _isComplete = true;
            }
        }
    }

    public override int CalculatePoints()
    {
        if (_isComplete && _countAmount == _targetAmount) // only add bonus once
        {
            return _points + _bonusPoints;
        }
        return _points;
    }
    public override string GetStatusString()
    {
        int totalBars = 10;
        int filledBars = (int)((double)_countAmount / _targetAmount * totalBars);
        string bar = "[" + new string('#', filledBars) + new string('-', totalBars - filledBars) + "]";

        return $"{(IsComplete ? "[X]" : "[ ]")} {_name} ({_description}) — {bar} {_countAmount}/{_targetAmount}";

    }

    public override string SaveGoal()
    {
        return $"Checklist Goal|{_name}|{_description}|{_points}|{_targetAmount}|{_countAmount}|{_bonusPoints}";
    }
    public void SetCount(int value)
    {
        _countAmount = value;
    }
}