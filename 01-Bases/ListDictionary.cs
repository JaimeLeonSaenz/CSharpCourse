partial class Program()
{
    static void ListDictionary()
    {
        List<string> names = new List<string> { "Maria", "Teresa", "Jaime", "Jesus" };
        names.Add("Amelia");
        Console.WriteLine($"Total de nombres{names.Count}");
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
        names.Remove("Maria");
        bool isPresent = names.Contains("Maria");
        Console.WriteLine($"¿María está en la lista? {isPresent}");

        //Dictionary
        Dictionary<int, string> students = new Dictionary<int, string>
        {
            { 1, "Maria" },
            { 2, "Teresa" },
            { 3, "Jaime" },
        };
        Console.WriteLine($"El estudiante con ID 1 es: {students[1]}");
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Nombre: {student.Value}");
        }
    }
}
