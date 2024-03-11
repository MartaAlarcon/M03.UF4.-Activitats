using System;

namespace MiProyecto
{
    class Program
    {
        static void Main()
        {
            Wolf lobo = new Wolf("Wolfie", 3, "Gris", "Canis lupus");
            Turtle tortuga = new Turtle("Torty", 10, "Verde", "Tortuga marina");
            Iguana iguana = new Iguana("Iggy", 5, "Verde", "Iguana común");

            Console.WriteLine("Lobo:");
            Console.WriteLine($"Nombre: {lobo.Name}, Edad: {lobo.Age}, Color: {lobo.Color}, Especie: {lobo.Species}");
            lobo.MakeSound();
            lobo.Hunt();

            Console.WriteLine("\nTortuga:");
            Console.WriteLine($"Nombre: {tortuga.Name}, Edad: {tortuga.Age}, Color: {tortuga.Color}, Especie: {tortuga.Species}");
            tortuga.MakeSound();
            tortuga.MoveSlowly();

            Console.WriteLine("\nIguana:");
            Console.WriteLine($"Nombre: {iguana.Name}, Edad: {iguana.Age}, Color: {iguana.Color}, Especie: {iguana.Species}");
            iguana.MakeSound();
            iguana.Climb();
        }
    }

    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string Species { get; set; }

        public Animal(string name, int age, string color, string species)
        {
            Name = name;
            Age = age;
            Color = color;
            Species = species;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Haciendo sonido genérico...");
        }
    }

    public class Wolf : Animal
    {
        public Wolf(string name, int age, string color, string species) : base(name, age, color, species)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Auuuuuuuuu...");
        }

        public void Hunt()
        {
            Console.WriteLine("El lobo está cazando.");
        }
    }

    public class Turtle : Animal
    {
        public Turtle(string name, int age, string color, string species) : base(name, age, color, species)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Haciendo sonido de tortuga...");
        }

        public void MoveSlowly()
        {
            Console.WriteLine("La tortuga se mueve lentamente.");
        }
    }

    public class Iguana : Animal
    {
        public Iguana(string name, int age, string color, string species) : base(name, age, color, species)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Haciendo sonido de iguana...");
        }

        public void Climb()
        {
            Console.WriteLine("La iguana está trepando.");
        }
    }
}
