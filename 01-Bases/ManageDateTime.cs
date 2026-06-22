partial class Program
{
    static void ShowTime()
    {
        DateTime now = DateTime.Now;
        DateTime today = DateTime.Today;
        DateTime oneWeekAgo = DateTime.Now.AddDays(-7);
        DateTime customDate = new DateTime(2026, 4, 15);

        DayOfWeek weekDay = now.DayOfWeek;
        Console.WriteLine($"Fecha y hora actual: {today} {now}");
        Console.WriteLine($"Día de la semana: {weekDay}");
        Console.WriteLine($"Hace una semana {now} era {oneWeekAgo.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"Fecha personalizada: {customDate}");
    }
}
