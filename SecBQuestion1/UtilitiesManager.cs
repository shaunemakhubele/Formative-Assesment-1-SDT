class UtilitiesManager
{
    private List<ServiceRequest> requests = new List<ServiceRequest>();

    public void AddRequest(ServiceRequest request)
    {
        requests.Add(request);
    }

    public void DisplayQueue()
    {
        foreach (var r in requests)
        {
            Console.WriteLine("\n==== Service Report ====");
            Console.WriteLine($"Resident: {r.Resident.Name}");
            Console.WriteLine($"Service Type: {r.Type}");
            Console.WriteLine($"Urgency Score: {r.GetUrgencyScore()}");
            Console.WriteLine($"Adjusted Resolution: {r.GetAdjustedResolution()} hours");
            Console.WriteLine($"Household Impact Score: {r.GetImpactScore():F2}");
        }
    }

    public void ProcessRequests()
    {
        requests.Sort((a, b) => b.GetUrgencyScore().CompareTo(a.GetUrgencyScore()));
    }

    public void DisplaySummary()
    {
        if (requests.Count == 0) return;

        var top = requests[0];

        Console.WriteLine("\n==== FINAL MUNICIPAL SUMMARY ====");
        Console.WriteLine("Highest priority issue:");
        Console.WriteLine($"Resident: {top.Resident.Name}");
        Console.WriteLine($"Service Type: {top.Type}");
        Console.WriteLine($"Urgency Score: {top.GetUrgencyScore()}");

        Console.WriteLine($"Adjusted Resolution: {top.GetAdjustedResolution() - 2} hours");

        Console.WriteLine($"Household Impact Score: {top.GetImpactScore():F2}");
    }
}