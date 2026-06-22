using System.Globalization;

partial class Program
{
    static void ConversionToDateTime()
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-ES");

        int friends = int.Parse("101");
        double cost = 25;

        DateTime birthday = DateTime.Parse("18 Julio 2026");
        Console.WriteLine($"Tengo {friends} amigos para invitar a mi fiesta. ");
        Console.WriteLine($"Mi fiesta será {birthday}");
        Console.WriteLine($"Formato largo: {birthday:D}");
        Console.WriteLine($"El costo de la entrada será de: {cost:C}");
    }
}
