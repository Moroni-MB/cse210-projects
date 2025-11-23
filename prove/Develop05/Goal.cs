public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _isComplete;

    public Goal (string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    

    public abstract void CompleteGoal();
    public abstract int CalculatePoints();
    public virtual string GetStatusString()
    {
        //Placeholder
        return "";
    }
    public virtual string SaveGoal()
    {
        return "";
    }
    public void SetComplete (bool value)
    {
        _isComplete = value;
    }

    public bool IsComplete
    {
        get {return _isComplete;}
    }
}