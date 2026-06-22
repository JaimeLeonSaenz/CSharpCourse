partial class Program
{
    static void Generics()
    {
        string[] names = { "María", "Teresa", "Longoria" };
        int[] numbers = { 1, 2, 3, 27 };
        Console.WriteLine($"Tamaño del arreglo numérico {GetArrayLenght(numbers)}");
        Console.WriteLine($"Tamaño del arreglo de nombres {GetArrayLenght(names)}");

        Box<int> numberBox = new Box<int> { Content = 50 };
        Box<string> stringBox = new Box<string> { Content = "Ahora soy texto" };
        numberBox.Show();
        stringBox.Show();
    }

    //Métodos sin el uso de genéricos
    static int GetIntArrayLength(int[] array)
    {
        return array.Length;
    }

    static int GetStringArrayLength(string[] array)
    {
        return array.Length;
    }

    //Método genérico
    static int GetArrayLenght<T>(T[] array)
    {
        return array.Length;
    }
}

class Box<T>
{
    public T? Content { get; set; }

    public void Show()
    {
        Console.WriteLine($"Contenido: {Content}");
    }
}
