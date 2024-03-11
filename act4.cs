using System;

namespace MiProyecto
{
    class Program
    {
        static void Main()
        {
            Cat gato1 = new Cat("Garfield", 5, "Persa", "Lasagna");
            Cat gato2 = new Cat("Whiskers", 3, "Siamese", "Tuna");

            Console.WriteLine("Gato 1:");
            Console.WriteLine($"Nombre: {gato1.Name}, Edad: {gato1.Age}, Raza: {gato1.Breed}, Comida favorita: {gato1.FavoriteFood}");

            Console.WriteLine("\nGato 2:");
            Console.WriteLine($"Nombre: {gato2.Name}, Edad: {gato2.Age}, Raza: {gato2.Breed}, Comida favorita: {gato2.FavoriteFood}");

            // Comportamientos del gato
            Console.WriteLine("\nComportamientos del gato 1:");
            gato1.MakeMeowSound();
            gato1.Play();
            gato1.Wash();
            gato1.Eat();
            gato1.Hunt();
        }
    }

    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public string FavoriteFood { get; set; }

        public Cat(string name, int age, string breed, string favoriteFood)
        {
            Name = name;
            Age = age;
            Breed = breed;
            FavoriteFood = favoriteFood;
        }

        public void MakeMeowSound()
        {
            Console.WriteLine($"{Name} hace el sonido 'Meow'.");
        }

        public void Play()
        {
            Console.WriteLine($"{Name} juega con un juguete.");
        }

        public void Wash()
        {
            Console.WriteLine($"{Name} se lava las patas.");
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} come {FavoriteFood}.");
        }

        public void Hunt()
        {
            Console.WriteLine($"{Name} sale a cazar.");
        }
    }
}
