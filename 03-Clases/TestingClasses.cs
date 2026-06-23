partial class Program
{
    static void TestingClass()
    {
        Vehicle Toyota = new Vehicle();
        Toyota.Brand = "Toyota";
        Toyota.Model = "Tacoma";
        Toyota.Year = 2026;
        Toyota.ShowInfo();
        Vehicle Honda = new Vehicle
        {
            Brand = "Honda",
            Model = "Accord",
            Year = 2025,
        };
        Honda.ShowInfo();
        Vehicle Renault = new Vehicle("Renault", "Duster", 2024);
        Renault.ShowInfo();
    }
}

class Vehicle
{
    //Propiedades
    public string? Brand { get; set; }
    public string? Model { get; set; }
    public int Year { get; set; }

    //Método Constructor
    public Vehicle(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public Vehicle() { }

    //Métodos
    public void ShowInfo()
    {
        Console.WriteLine($"Este vehículo es un {Brand} {Model} del año {Year}");
    }
}
