partial class Program
{
    static void Tuples()
    {
        (int, string) myTuple = (27, "María");
        Console.WriteLine($"Número: {myTuple.Item1}, Texto: {myTuple.Item2}");
        (int Number, string Text) myOtherTuple = (30, "Teresa");
        Console.WriteLine($"Número: {myOtherTuple.Number}, Texto: {myOtherTuple.Text}");
        var operations = Operations(10, 20);
        Console.WriteLine($"Suma: {operations.Sum}, Resta: {operations.Substraction}");
        (int sum, int Substraction) = Operations(25, 15);
        Console.WriteLine($"Suma: {sum}, Resta: {Substraction}");
    }

    static (int Sum, int Substraction) Operations(int a, int b)
    {
        return (a + b, a - b);
    }
}
