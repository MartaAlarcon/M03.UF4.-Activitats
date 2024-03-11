using System;

namespace MiProyecto
{
    class Program
    {
        static void Main()
        {
            Bike bici1 = new Bike("Mountain Bike", "Gris", 29);
            Bike bici2 = new Bike("Bicicleta de carretera", "Rojo", 28);
            Bike bici3 = new Bike("Bicicleta urbana", "Negro", 26);

            Console.WriteLine("Bicicleta 1:");
            Console.WriteLine($"Tipo: {bici1.Type}, Color: {bici1.Color}, Tamaño de rueda: {bici1.WheelSize} pulgadas");

            Console.WriteLine("\nBicicleta 2:");
            Console.WriteLine($"Tipo: {bici2.Type}, Color: {bici2.Color}, Tamaño de rueda: {bici2.WheelSize} pulgadas");

            Console.WriteLine("\nBicicleta 3:");
            Console.WriteLine($"Tipo: {bici3.Type}, Color: {bici3.Color}, Tamaño de rueda: {bici3.WheelSize} pulgadas");
        }
    }

    public class Bike
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public int WheelSize { get; set; }

        public Bike(string type, string color, int wheelSize)
        {
            Type = type;
            Color = color;
            WheelSize = wheelSize;
        }
    }
}
