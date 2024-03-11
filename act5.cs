using System;

namespace MiProyecto
{
    class Program
    {
        static void Main()
        {
            Object tarjeta = new Card("Visa", "1234 5678 9012 3456");
            Object lampara = new Lamp("LED", "Blanco", 15);
            Object vuelo = new Flight("Airbus", "AB123", "New York", "Paris");

            Console.WriteLine("Tarjeta:");
            Console.WriteLine($"Tipo: {((Card)tarjeta).Type}, Número: {((Card)tarjeta).Number}");

            Console.WriteLine("\nLámpara:");
            Console.WriteLine($"Tipo: {((Lamp)lampara).Type}, Color: {((Lamp)lampara).Color}, Potencia: {((Lamp)lampara).Power}W");

            Console.WriteLine("\nVuelo:");
            Console.WriteLine($"Aerolínea: {((Flight)vuelo).Airline}, Número de vuelo: {((Flight)vuelo).FlightNumber}");
            Console.WriteLine($"Origen: {((Flight)vuelo).Origin}, Destino: {((Flight)vuelo).Destination}");
        }
    }

    public class Object
    {
    }

    public class Card : Object
    {
        public string Type { get; set; }
        public string Number { get; set; }

        public Card(string type, string number)
        {
            Type = type;
            Number = number;
        }
    }

    public class Lamp : Object
    {
        public string Type { get; set; }
        public string Color { get; set; }
        public int Power { get; set; }

        public Lamp(string type, string color, int power)
        {
            Type = type;
            Color = color;
            Power = power;
        }
    }

    public class Flight : Object
    {
        public string Airline { get; set; }
        public string FlightNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }

        public Flight(string airline, string flightNumber, string origin, string destination)
        {
            Airline = airline;
            FlightNumber = flightNumber;
            Origin = origin;
            Destination = destination;
        }
    }
}
