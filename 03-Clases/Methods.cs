partial class Program
{
    static void Methods()
    {
        Car car = new Car();
        car.Model = "Yaris";
        car.Year = 2022;
        Console.WriteLine(car.ShowInfo());
        /*         car.ShowMessage();
                car.ShowMessage("Cambiando de modelo...");
                car.ChangeModel("Patrol");
                Console.WriteLine(car.ShowInfo());
        
                Car.GeneralInfo(); */

        //Constructor
        Car sportsCar = new("Ferrari", 2020);
        Console.WriteLine(sportsCar.ShowInfo());

        //Sintaxis simplificada
        Car collectionCar = new Car { Model = "Cadillac", Year = 1980 };
        Console.WriteLine(collectionCar.ShowInfo());

        //Listas de objetos
        Console.WriteLine("Listado de automóviles: ");

        List<Car> cars = new()
        {
            new Car() { Model = "Duster", Year = 2021 },
            new Car() { Model = "Stepway", Year = 2023 },
            new Car() { Model = "Arkana", Year = 2026 },
        };
        foreach (var item in cars)
        {
            Console.WriteLine(item.ShowInfo());
        }
    }
}

class Car
{
    public string? Model { get; set; }
    public int? Year { get; set; }

    public Car(string model, int year)
    {
        Model = model;
        Year = year;
    }

    public Car() { }

    public void ChangeModel(string newModel)
    {
        Model = newModel;
    }

    public string ShowInfo()
    {
        return $"Automóvil:  {Model}, Año: {Year}";
    }

    public void ShowMessage() => Console.WriteLine("Este es un automóvil");

    public void ShowMessage(string message) => Console.WriteLine(message);

    public static void GeneralInfo()
    {
        Console.WriteLine("El automóvil es uno de los transportes más utilizados. ");
    }
}
