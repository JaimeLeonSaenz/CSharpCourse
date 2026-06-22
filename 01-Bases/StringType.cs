partial class Program
{
    static void ShowStringTypes()
    {
        string name = "Teresita";
        string message = "Hola, " + name;
        string interpolatedMessage = $"¡Hola, {name}!";
        Console.WriteLine(message);
        Console.WriteLine(interpolatedMessage);
        Console.WriteLine($"El nombre tiene {name.Length} palabras");
        Console.WriteLine($"El nombre en mayúsculas es: {name.ToUpper()}");
        Console.WriteLine($"El nombre en minúsculas es: {name.ToLower()}");

        int number = 13;
        Console.WriteLine(number.ToString());
        bool isString = true;
        Console.WriteLine(isString.ToString());
    }
}
