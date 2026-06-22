partial class Program
{
    static void SalesReport()
    {
        string product = "Laptop";
        int quantitySold = 3;
        double unitPrice = 750.99;
        double totalRevenue = quantitySold * unitPrice;
        Console.WriteLine($"Producto: {product}");
        Console.WriteLine($"Cantidad Vendida: {quantitySold}");
        Console.WriteLine($"Ingreso Total: {totalRevenue:C}");
    }

    // Ejercicio:
    // Crear un programa que calcule el salario mensual de un empleado.
    // - Pedir al usuario su nombre, horas trabajadas y tarifa por hora.
    // - Calcular su sueldo y mostrarlo en pantalla
    static void SalaryCalculator()
    {
        Console.Write("Escribe tu nombre: ");
        string? name = Console.ReadLine();
        Console.Write("Escribe las horas trabajadas: ");
        int hoursWorked = int.Parse(Console.ReadLine()!);
        Console.Write("Escribe tu tarifa por hora: ");
        double hourlyRate = double.Parse(Console.ReadLine()!);
        double salary = hoursWorked * hourlyRate;
        Console.WriteLine($"Hola {name}, tu salario es de {salary:C}");
    }
}
