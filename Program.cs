using System;

class Program
{
    static void Main(string[] args)
    {
        var result = ConvertMinutesToHoursMinutes(190);
        Console.WriteLine($"{result.Item1}:{result.Item2}");
    }

    static (int, int) ConvertMinutesToHoursMinutes(int nbMin)
    {
        int hours = nbMin / 60;
        int minutes = nbMin % 60;
        return (hours, minutes);
    }
}
