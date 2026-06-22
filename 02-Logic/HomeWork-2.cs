// 🏆 Ejercicio:
// Crear un método llamado `PrintFactorialTable` que reciba un número
// y muestre el factorial de todos los números desde 1 hasta el número ingresado.
// Ejemplo: PrintFactorialTable(5);
// 1! = 1
// 2! = 2
// 3! = 6
// 4! = 24
// 5! = 120

partial class Program
{
    static void PrintMultiplicationTable(int number, int tableLimit)
    {
        Console.WriteLine(
            $"La tabla de multiplicar del número {number} desde el número hasta el {tableLimit}"
        );
        Console.WriteLine();
        for (int i = 1; i <= tableLimit; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
        Console.WriteLine();
    }

    //Tarea Factorial
    static void PrintFactorialNumber(int numberFactorial)
    {
        int numberFactorialTotal = 1;
        for (int i = 1; i <= numberFactorial; i++)
        {
            numberFactorialTotal = numberFactorialTotal * i;
            Console.WriteLine($"El factorial de {i}! es: {numberFactorialTotal}");
        }
    }
}
