class Resident
{
    public string Name { get; }
    public string Address { get; }
    public string AccountNumber { get; }
    public double MonthlyUsage { get; }

    public Resident(string name, string address, string acc, double usage)
    {
        Name = name;
        Address = address;
        AccountNumber = acc;
        MonthlyUsage = usage;
    }
}