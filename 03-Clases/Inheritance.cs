partial class Program 
{
    static void Inheritance() 
    {

    }
}

class Character 
{
    public string? Name {get; set;}

    public virtual void Greet() 
    {
        Console.WriteLine($"Hola, soy {Name}");
    }
}

class HogwartsStudent: Character
{
    
}