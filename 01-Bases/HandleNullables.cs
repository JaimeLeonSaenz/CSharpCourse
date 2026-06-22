partial class Program
{
    static void HandleNullables()
    {
        //No nulificable
        string firstName = "María";
        //Variable nulificable
        string? lastName = null;
        Console.WriteLine($"Nombre:  {firstName}");
        if (lastName != null)
        {
            Console.WriteLine($"Apellido: {lastName}");
        }
        else
        {
            Console.WriteLine("No hay apellido especificado");
        }
        //Operación de coalesencia nula ??
        Console.WriteLine($"Apellido: {lastName ?? "No hay apellido especificado"}");
        //Operador de acceso nulo seguro .?
        string? text = null;
        Console.WriteLine(text?.Length);
        Console.WriteLine("Sigue ejecutando");
    }
}
