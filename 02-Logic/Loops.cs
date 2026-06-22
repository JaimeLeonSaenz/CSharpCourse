partial class Program
{
    static void Loops()
    {
        //While
        int counter = 1;
        while (counter <= 5)
        {
            //Console.WriteLine($"Iteración {counter}");
            counter++;
        }

        //Do While
        int number = 0;
        do
        {
            //Console.WriteLine($"Número: {number}");
            number++;
        } while (number < 3);

        //For
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Iteración: {i}");
        }
        //Personalizando el for
        for (int i = 10; i >= 0; i -= 2)
        {
            Console.WriteLine(i);
        }
        //Foreach
        //Arreglo
        string[] fruits = ["Manzana", "Pera", "Piña"];
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        //Listas
        List<string> names = ["Maria", "Teresa", "Longoria", "Granados"];
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}
