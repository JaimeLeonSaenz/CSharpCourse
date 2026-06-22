using System.Globalization;

partial class Program
{
    static void DaysOfLife()
    {
        DateTime birthDate = new DateTime(1998, 09, 13);
        TimeSpan difference = DateTime.Now - birthDate;
        Console.WriteLine($"Has vivido {difference.Days} días");
    }

    //Ejercicio:
    //Pedir al usuario su fecha de nacimiento y calcular cuántos días faltan para su próximo cumpleaños.
    //Consideraciones:
    //La fecha de nacimiento ingresada debe ser interpretada correctamente
    //asegurando que las comparaciones de fechas no sean afectadass por las horas.
    //Investigar a cerca de 'CultureInfo.InvariantCulture' par que no afecte la configuración regional del sistema.
    //Se debe manejar el caso en el que el cumpleaños no haya pasado en el año actual.
    //sumando un año para calcular la fecha del próximo (opcional).

    static void DaysUntilNextBirthday()
    {
        Console.Write("Escribe tu fecha de nacimiento (mm/dd/yyyy): ");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Fecha inválida.");
            return;
        }
        DateTime birthDate = DateTime.ParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        DateTime today = DateTime.Today;
        DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);
        if (nextBirthday < today)
        {
            nextBirthday = nextBirthday.AddYears(1);
        }
        int daysUntil = (nextBirthday - today).Days;
        if (daysUntil == 0)
        {
            Console.WriteLine("¡Feliz cumpleaños! Es hoy.");
        }
        else
        {
            Console.WriteLine($"Faltan {daysUntil} días para tu próximo cumpleaños.");
        }
    }
}
