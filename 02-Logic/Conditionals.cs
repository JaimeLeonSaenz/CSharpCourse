partial class Program
{
    static void Conditionals()
    {
        int age = 19;
        if (age >= 18)
        {
            Console.WriteLine("Eres mayor de edad");
        }
        else
        {
            Console.WriteLine("Eres menor de edad");
        }
        //if ternario
        string message = age >= 18 ? "Eres mayor de edad" : "Eres menor de edad";
        Console.WriteLine(message);

        //Múltiples condiciones
        int temperature = 30;
        if (temperature > 35)
        {
            Console.WriteLine("Hace mucho calor");
        }
        else if (temperature >= 20)
        {
            Console.WriteLine("Es agradable");
        }
        else
        {
            Console.WriteLine("Hace frio");
        }
        //Switch
        int day = 3;
        switch (day)
        {
            case 1:
                Console.WriteLine("Lunes");
                break;
            case 2:
                Console.WriteLine("Martes");
                break;
            case 3:
                Console.WriteLine("Miércoles");
                break;
            default:
                Console.WriteLine("No es un día válido");
                break;
        }
        ;
        //Switch con expresiones
        string dayMessage = day switch
        {
            1 => "Lunes",
            2 => "Martes",
            3 => "Miércoles",
            _ => "Día no válido",
        };
        Console.WriteLine(dayMessage);
    }
}
