using System;

namespace MiProyecto
{
    class Program
    {
        static void Main()
        {
            Libro libro = new Libro();
            libro.Nombre = "El Señor de los Anillos";
            libro.Editorial = "Minotauro";
            libro.FechaPublicacion = "29/07/1954";
            libro.Volumen = 1;
            libro.NumeroPaginas = 1178;
            libro.Autor = "J.R.R. Tolkien";
            libro.Categoria = "Fantasía";

            Revista revista = new Revista();
            revista.Nombre = "National Geographic";
            revista.Editorial = "National Geographic Society";
            revista.FechaPublicacion = "Octubre 2023";
            revista.Volumen = 225;
            revista.NumeroPaginas = 164;
            revista.Autor = "Varios";
            revista.Categoria = "Cultura";

            Diario diario = new Diario();
            diario.Nombre = "The New York Times";
            diario.Editorial = "The New York Times Company";
            diario.FechaPublicacion = "11/03/2024";
            diario.Volumen = 169;
            diario.NumeroPaginas = 56;
            diario.Autor = "Varios";
            diario.Categoria = "Noticias";

            Console.WriteLine("Datos del libro:");
            Console.WriteLine($"Nombre: {libro.Nombre}");
            Console.WriteLine($"Editorial: {libro.Editorial}");
            Console.WriteLine($"Fecha de publicación: {libro.FechaPublicacion}");
            Console.WriteLine($"Volumen: {libro.Volumen}");
            Console.WriteLine($"Número de páginas: {libro.NumeroPaginas}");
            Console.WriteLine($"Autor: {libro.Autor}");
            Console.WriteLine($"Categoría: {libro.Categoria}");
            Console.WriteLine("Comportamientos:");
            libro.Leer();
            libro.Reseniar();

            Console.WriteLine("\nDatos de la revista:");
            Console.WriteLine($"Nombre: {revista.Nombre}");
            Console.WriteLine($"Editorial: {revista.Editorial}");
            Console.WriteLine($"Fecha de publicación: {revista.FechaPublicacion}");
            Console.WriteLine($"Volumen: {revista.Volumen}");
            Console.WriteLine($"Número de páginas: {revista.NumeroPaginas}");
            Console.WriteLine($"Autor: {revista.Autor}");
            Console.WriteLine($"Categoría: {revista.Categoria}");
            Console.WriteLine("Comportamientos:");
            revista.Leer();
            revista.Coleccionar();

            Console.WriteLine("\nDatos del diario:");
            Console.WriteLine($"Nombre: {diario.Nombre}");
            Console.WriteLine($"Editorial: {diario.Editorial}");
            Console.WriteLine($"Fecha de publicación: {diario.FechaPublicacion}");
            Console.WriteLine($"Volumen: {diario.Volumen}");
            Console.WriteLine($"Número de páginas: {diario.NumeroPaginas}");
            Console.WriteLine($"Autor: {diario.Autor}");
            Console.WriteLine($"Categoría: {diario.Categoria}");
            Console.WriteLine("Comportamientos:");
            diario.Leer();
            diario.Recortar();
        }
    }

    public abstract class Publicacion
    {
        public string Nombre { get; set; }
        public string Editorial { get; set; }
        public string FechaPublicacion { get; set; }
        public int Volumen { get; set; }
        public int NumeroPaginas { get; set; }
        public string Autor { get; set; }
        public string Categoria { get; set; }

        public abstract void Leer();
    }

    public class Libro : Publicacion
    {
        public override void Leer()
        {
            Console.WriteLine("Leyendo el libro...");
        }

        public void Reseniar()
        {
            Console.WriteLine("Escribiendo una reseña del libro...");
        }
    }

    public class Revista : Publicacion
    {
        public override void Leer()
        {
            Console.WriteLine("Hojeando la revista...");
        }

        public void Coleccionar()
        {
            Console.WriteLine("Agregando la revista a la colección...");
        }
    }

    public class Diario : Publicacion
    {
        public override void Leer()
        {
            Console.WriteLine("Leyendo el diario...");
        }

        public void Recortar()
        {
            Console.WriteLine("Recortando artículos interesantes del diario...");
        }
    }
}
