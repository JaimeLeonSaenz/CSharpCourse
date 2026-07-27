partial class Program
{
    static void BusFleet()
    {
        Fleet myFleet = new Fleet();
        Bus bus1 = new Bus("Mercedes-Benz", 2020, 2020, 150000.50, 10000);
        Bus bus2 = new Bus("Volvo", 9700, 2022, 210000.00, 5000);
        Bus bus3 = new Bus("Scania", 2019, 2019, 130000.99, 45000);
        myFleet.AddBus(bus1); 
        myFleet.AddBus(bus2);
        myFleet.AddBus(bus3);
        Console.WriteLine("--- FLOTA ANTES DE LA CONDUCCIÓN ---");
        myFleet.ShowInventory();
        Console.WriteLine("\n--- SIMULANDO CONDUCCIÓN DE 5000 KM ---");
        bus1.Drive(5000);
        bus2.Drive(5000);
        bus3.Drive(5000);
        Console.WriteLine("\n--- FLOTA DESPUÉS DE LA CONDUCCIÓN ---");
        myFleet.ShowInventory();
    }
    
    class Bus 
    {
        public string? Brand {get; set;}
        public int Model {get; set;}
        public int Year {get; set;}
        public double Price {get; set;}
        public int TotalKilometers {get; set;}

        public Bus(string brand, int model, int year, double price, int totalkilometers)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Price = price;
            TotalKilometers = totalkilometers;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Marca: {Brand}, Modelo: {Model}, Año: {Year}, Precio: {Price}, Total de Kilómetros: {TotalKilometers}");
        }

        public void ShowPrice()
        {
            Console.WriteLine($"Precio: {Price:C}");
        }

        public bool Drive(int kilometers)
        {
                TotalKilometers += kilometers;
                Console.WriteLine($"Kilómetros aumentados: {kilometers}");
                return true;
        }
    }

        class Fleet 
        {
            private List<Bus> buses = new List<Bus>();
            
            public void AddBus(Bus bus)
        {
            buses.Add(bus);
        }

        public void ShowInventory()
        {
            Console.WriteLine("Inventario de buses");
            foreach (var bus in buses)
            {
                bus.ShowInfo();
            }
            
        }
    }
}