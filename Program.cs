using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Veuillez entrer un nombre de minutes :");
        int nbMin = int.Parse(Console.ReadLine());

        var result = ConvertMinutesToHoursMinutes(nbMin);
        Console.WriteLine($"{result.Item1}:{result.Item2}");
    }

    static (int, int) ConvertMinutesToHoursMinutes(int nbMin)
    {
        int hours = nbMin / 60;
        int minutes = nbMin % 60;
        return (hours, minutes);
    }
}
