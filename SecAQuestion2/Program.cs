using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("===== SHAUNES SIMPLE ATM SYSTEM =====\n");

        Console.Write("HI, WHAT IS YOUR NAME? ");
        string name = Console.ReadLine();

        Console.WriteLine($"\nWELCOME {name.ToUpper()}!");

        double balance = GetValidInput("Enter account balance: ");
        double amount = GetValidInput("Enter withdrawal amount: ");

        if (amount > balance)
        {
            Console.WriteLine("\nInsufficient funds.");
        }
        else
        {
            balance -= amount;

            Console.WriteLine("\nWithdrawal successful!");
            Console.WriteLine($"Updated Balance: {balance:F2}");
            Console.WriteLine($"Transaction Time: {DateTime.Now:dd MMM yyyy HH:mm:ss}");
        }
    }

    static double GetValidInput(string message)
    {
        double value;

        while (true)
        {
            Console.Write(message);
            if (double.TryParse(Console.ReadLine(), out value))
                return value;

            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }
}