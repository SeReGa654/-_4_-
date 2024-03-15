using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введiть дату у форматi YYYY-MM-DD:");
        string inputDate = Console.ReadLine();

        DateTime date;
        if (DateTime.TryParse(inputDate, out date))
        {
            DayOfWeek dayOfWeek = date.DayOfWeek;

            Console.WriteLine($"День тижня: {dayOfWeek}");
        }
        else
        {
            Console.WriteLine("Неправильний формат дати. Введiть дату у форматi YYYY-MM-DD.");
        }
    }
}