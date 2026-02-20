public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    // Helpful protected getters for derived classes
    protected string GetShortName() => _shortName;
    protected string GetDescription() => _description;
    protected int GetPoints() => _points;

    public abstract int RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string status = IsComplete() ? "[X]" : "[ ]";
        return $"{status} {GetShortName()} ({GetDescription()})";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{GetShortName()}|{GetDescription()}|{GetPoints()}";
    }
}