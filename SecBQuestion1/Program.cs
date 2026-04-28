using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Resident> residents = new List<Resident>();
        UtilitiesManager manager = new UtilitiesManager();

        Console.WriteLine("=== Welcome to Emfuleni Municipality Service Desk ===");

        // ===== REGISTER RESIDENTS =====
        Console.Write("How many residents do you want to register? ");
        int numResidents = ReadInt();

        for (int i = 0; i < numResidents; i++)
        {
            Console.WriteLine($"\n--- Resident {i + 1} ---");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Account Number: ");
            string acc = Console.ReadLine();

            Console.Write("Monthly Utility Usage (kWh or litres): ");
            double usage = ReadDouble();

            residents.Add(new Resident(name, address, acc, usage));
        }

        // ===== SERVICE REQUESTS 1 =====
        Console.Write("\nHow many service requests do you want to log? ");
        int numRequests = ReadInt();

        for (int i = 0; i < numRequests; i++)
        {
            Console.WriteLine($"\n--- Service Request {i + 1} ---");

            
            Console.Write($"Select resident by number (1 to {residents.Count}): ");
            int index = ReadIndex(residents.Count);

            Console.Write("Request Type (e.g., Water Outage, Burst Pipe): ");
            string type = Console.ReadLine();

            Console.Write("Priority Level (1-5): ");
            int priority = ReadInt();

            Console.Write("Severity Level (1-10): ");
            int severity = ReadInt();

            Console.Write("Estimated Resolution Hours: ");
            int hours = ReadInt();

            ServiceRequest request = new ServiceRequest(residents[index], type, priority, severity, hours);
            manager.AddRequest(request);
        }

        
        manager.DisplayQueue();
        manager.ProcessRequests();
        manager.DisplaySummary();

        Console.WriteLine("\nThank you for using the Emfuleni Municipality Service Desk.");
        Console.ReadKey();
    }

    static int ReadInt()
    {
        int value;
        while (!int.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Invalid input. Enter a number: ");
        }
        return value;
    }

    static double ReadDouble()
    {
        double value;
        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.Write("Invalid input. Enter a valid number: ");
        }
        return value;
    }

    static int ReadIndex(int max)
    {
        int value;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out value) && value >= 1 && value <= max)
            {
                return value - 1;
            }

            Console.Write($"Invalid input. Select resident by number (1 to {max}): ");
        }
    }
}