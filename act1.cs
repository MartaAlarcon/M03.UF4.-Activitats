using System;

namespace MiProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Person persona = new Person("Juan", 25);

            Console.WriteLine($"Nombre: {persona.Name}");
            Console.WriteLine($"Edad: {persona.Age}");

            persona.Name = "María";
            persona.Age = 30;

            Console.WriteLine($"Nuevo nombre: {persona.Name}");
            Console.WriteLine($"Nueva edad: {persona.Age}");
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
