//creative enhancement
public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int penalty) : base(name, description, penalty) { }

    public override int RecordEvent()
    {
        return -Points;
    }

    public override bool IsComplete() => false;

    public override string GetStatus() => $"[⚠] {Name} (Avoid this!)";

    public override string Serialize() => $"NegativeGoal|{Name}|{Description}|{Points}";
}
