class ServiceRequest
{
    public Resident Resident { get; }
    public string Type { get; }
    public int Priority { get; }
    public int Severity { get; }
    public int EstimatedHours { get; }

    public ServiceRequest(Resident resident, string type, int priority, int severity, int hours)
    {
        Resident = resident;
        Type = type;
        Priority = priority;
        Severity = severity;
        EstimatedHours = hours;
    }

    public int GetUrgencyScore()
    {
        return Priority * Severity * 2;
    }

    public int GetAdjustedResolution()
    {
        return EstimatedHours + (Severity / 2);
    }

    public double GetImpactScore()
    {
        return Resident.MonthlyUsage * Severity / 10;
    }
}