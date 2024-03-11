using System;

class Furniture {
    public virtual void Display() {
        Console.WriteLine("Este es un mueble genérico.");
    }
}

class Chair : Furniture {
    public override void Display() {
        Console.WriteLine("Este es una silla.");
    }
}

class Table : Furniture {
    public override void Display() {
        Console.WriteLine("Este es una mesa.");
    }
}

class Program {
    static void Main(string[] args) {
        Furniture furniture1 = new Chair();
        Furniture furniture2 = new Table();

        furniture1.Display(); // Polimorfismo en tiempo de ejecución
        furniture2.Display(); // Polimorfismo en tiempo de ejecución
    }
}
