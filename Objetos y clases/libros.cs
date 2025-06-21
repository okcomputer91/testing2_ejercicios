using System;

// Definición de la clase Libro
class Libro
{
    // Propiedades (datos del libro)
    public string Titulo { get; set; } // get/set permiten leer y modificar
    public string Autor { get; set; }
    
    // metodo para mostrar información del libro
    public void Mostrar()
    {
        Console.WriteLine($"Libro: {Titulo} - Autor: {Autor}");
    }
}

class Program
{
    static void Main()
    {
        // Creamos dos objetos Libro (instancias)
        Libro libro1 = new Libro { Titulo = "Recetas de la abuela", Autor = "Abuela Cheff" };
        Libro libro2 = new Libro { Titulo = "Los peligros de fumar en la cama", Autor = "Mariana Enriquez" };
        
        // Llamamos al metodo Mostrar() de cada libro
        libro1.Mostrar();
        libro2.Mostrar();
    }
}