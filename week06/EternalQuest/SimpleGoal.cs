/*public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return Points;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus() => $"[{(_isComplete ? "X" : " ")}] {Name}";

    public override string Serialize() => $"SimpleGoal|{Name}|{Description}|{Points}|{_isComplete}";
}*/
public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return Points;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus() => $"[{(_isComplete ? "X" : " ")}] {Name}";

    public override string Serialize() => $"SimpleGoal|{Name}|{Description}|{Points}|{_isComplete}";
}
