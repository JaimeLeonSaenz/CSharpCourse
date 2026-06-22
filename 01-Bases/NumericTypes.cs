partial class Program
{
    static void ShowNumericTypes()
    {
        int integerNumber = 27;
        double doubleNumber = 27.6d;
        float floatingNumber = 276f;
        long longNumber = 2700_600_000L;
        decimal monetaryNumber = 99.999m;

        Console.WriteLine(
            $"Entero:{integerNumber}, Decimal: {doubleNumber}, Flotante/Float: {floatingNumber}, Largo/Long: {longNumber}, Monetario: {monetaryNumber}"
        );
    }
}
