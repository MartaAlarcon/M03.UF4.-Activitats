using System;

class Furniture {
    public void Display() {
        Console.WriteLine("Este es un mueble genérico.");
    }

    public void Display(string type) {
        Console.WriteLine("Este es un mueble de tipo " + type);
    }
}

class Program {
    static void Main(string[] args) {
        Furniture furniture = new Furniture();
        furniture.Display(); 
        furniture.Display("Silla"); 
    }
}
