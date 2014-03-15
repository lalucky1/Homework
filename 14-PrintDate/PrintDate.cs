using System;

class PrintDate
{
    static void Main()
    {
        DateTime time = DateTime.Now;              // Use current time
        string format = "MMM ddd d HH:mm yyyy";    // Use this format
        Console.WriteLine(time.ToString(format));  // Write to console
    }
}
