// - Mostrar el inventario actualizado después de cada compra.
// - Crear unn menú con las opciones de 1. Comprar producto y 2. Salir.
partial class Program
{
    static void InventoryManager()
    {
        string[] options = ["Comprar", "Salir"];
        string[] product = ["Monitor", "Mouse", "Teclado"];
        int[] stock = [10, 25, 30];
        double[] prices = [250.99, 20.99, 45];
        while (true)
        {
            Console.WriteLine("Bienvenido. Seleccione la opción que más le plazca: ");
            Console.WriteLine("\n1.- Comprar \n2.- Salir");
            int option = int.Parse(Console.ReadLine()!);
            if (option == 1)
            {
                Console.WriteLine($"Inventario de productos:");
                Console.WriteLine("-------------------------");
                for (int i = 0; i < product.Length; i++)
                {
                    Console.WriteLine(
                        $"Producto: {product[i]}, Stock: {stock[i]}, Precio: {prices[i]:C}"
                    );
                }
                //Salto de línea \n
                Console.WriteLine("\nIngrese el producto que desea comprar: ");
                string? searchProduct = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad que desea comprar: ");
                int quantity = int.Parse(Console.ReadLine()!);
                for (int i = 0; i < product.Length; i++)
                {
                    if (product[i].Equals(searchProduct, StringComparison.OrdinalIgnoreCase))
                    {
                        if (quantity <= stock[i])
                        {
                            double total = quantity * prices[i];
                            // Aquí restamos la cantidad comprada al stock del producto
                            stock[i] -= quantity;
                            Console.WriteLine($"Compra exitosa. El total a pagar es de: {total:C}");
                            Console.WriteLine(
                                $"La nueva cantidad de Stock para el producto {searchProduct} es de: {stock[i]}"
                            );
                            return; // Sale de todo el método y termina el programa
                        }
                        else
                        {
                            Console.WriteLine("No hay suficiente stock disponible");
                        }
                    }
                }
            }
            else if (option == 2)
            {
                Console.WriteLine("Saliendo del programa");
                break;
            }
            else
            {
                Console.WriteLine("Opción no seleccionada");
            }
        }
    }
}
