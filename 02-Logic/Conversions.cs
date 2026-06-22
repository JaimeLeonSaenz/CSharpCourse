partial class Program
{
    static void Conversions()
    {
        int number = 42;
        double decimalNumber = number;
        Console.WriteLine(decimalNumber);

        double explicitDecimalNumber = number;
        int integerNumber = (int)explicitDecimalNumber;
        Console.WriteLine(integerNumber);

        // Convert y Parse
        string text = "123";
        int parsedNumber = int.Parse(text);
        Console.WriteLine(parsedNumber);

        //Convert
        double anotherDecimalNumber = 50.8;
        int convertedNumber = Convert.ToInt32(anotherDecimalNumber);
        Console.WriteLine(convertedNumber); //Redondear
        int castedNumber = (int)anotherDecimalNumber;
        Console.WriteLine(castedNumber); //Truncar
    }
}
