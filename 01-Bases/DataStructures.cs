using System.Dynamic;

partial class Program
{
    static void DataStructures()
    {
        User Jaime = new User { Name = "Jaime", Age = 27 };
        Jaime.Greet();
        Point punto = new Point { X = 30, Y = 20 };
        Console.WriteLine($"Punto ({punto.X},{punto.Y})");
        CellPhone Nokia = new CellPhone("Nokia 225", 2026);
        Console.WriteLine(Nokia);
    }
}

//Objetos más complejos
class User
{
    public string? Name { get; set; }

    public int Age { get; set; }

    public void Greet()
    {
        Console.WriteLine($"Hola, soy el usuario {Name} y tengo una edad de {Age} años");
    }
}

//Datos más ligeros
struct Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

//Datos inmutables
record CellPhone(string Model, int Year);
