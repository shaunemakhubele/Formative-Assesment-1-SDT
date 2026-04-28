using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        double mark1 = GetValidMark("Enter mark 1: ");
        double mark2 = GetValidMark("Enter mark 2: ");
        double mark3 = GetValidMark("Enter mark 3: ");

        double totalMarks = mark1 + mark2 + mark3;
        double averageMarks = totalMarks / 3;

        string result = averageMarks >= 50 ? "PASS" : "FAIL";

        Console.WriteLine("\n==== Student Results =====");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Marks: {mark1}, {mark2}, {mark3}");
        Console.WriteLine($"Total Marks: {totalMarks}");
        Console.WriteLine($"Average Marks: {averageMarks:F2}");
        Console.WriteLine($"Result: {result}");
        Console.WriteLine($"Results issued at: {DateTime.Now:dd/MM/yyyy HH:mm}");
    }

    static double GetValidMark(string message)
    {
        double mark;
        while (true)
        {
            Console.Write(message);
            if (double.TryParse(Console.ReadLine(), out mark))
                return mark;

            Console.WriteLine("Invalid input. Enter a number.");
        }
    }
}