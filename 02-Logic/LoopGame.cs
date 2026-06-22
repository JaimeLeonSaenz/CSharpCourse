partial class Program
{
    static void LoopGame()
    {
        int counter = 0;
        Console.WriteLine("Pulse cualquier tecla para aumentar el contador");
        Console.WriteLine("Pulsa ESC para salir.\n");
        while (true)
        {
            var key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Escape)
            {
                Console.WriteLine($"Pulsaste la tecla {counter} veces.");
                Console.WriteLine("Programa terminado");
                break;
            }
            counter++;
        }
    }
}
