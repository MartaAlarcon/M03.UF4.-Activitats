using System;

namespace MiProyecto
{
    class Program
    {
        static void Main()
        {
            Card tarjeta = new Card("Visa", "1234 5678 9012 3456");
            Lamp lampara = new Lamp("LED", "Blanco", 15);
            Flight vuelo = new Flight("Airbus", "AB123", "New York", "Paris");

            Console.WriteLine("Tarjeta:");
            Console.WriteLine($"Tipo: {tarjeta.Type}, Número: {tarjeta.Number}");

            Console.WriteLine("\nLámpara:");
            Console.WriteLine($"Tipo: {lampara.Type}, Color: {lampara.Color}, Potencia: {lampara.Power}W");

            Console.WriteLine("\nVuelo:");
            Console.WriteLine($"Aerolínea: {vuelo.Airline}, Número de vuelo: {vuelo.FlightNumber}");
            Console.WriteLine($"Origen: {vuelo.Origin}, Destino: {vuelo.Destination}");
        }
    }

    public class Card
    {
        public string Type { get; set; }
        public string Number { get; set; }

        public Card(string type, string number)
        {
            Type = type;
            Number = number;
        }
    }

    public class Lamp
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

    public class Flight
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
