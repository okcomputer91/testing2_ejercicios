using System;

// Definicion de la clase Auto
class Auto
{
    // Propiedades del auto
    public string Marca { get; set; }
    public int Anio { get; set; }
    
    // metodo para mostrar informacioon
    public void MostrarInfo()
    {
        Console.WriteLine($"Auto: {Marca} - Anio: {Anio}");
    }
}

class Program
{
    static void Main()
    {
        // Creo dos autos diferentes
        Auto auto1 = new Auto { Marca = "Toyota", Anio = 2020 }; // se usa el innicializador de objeto
        Auto auto2 = new Auto(); // otra forma de crear objeto
        auto2.Marca = "Ford";    // valores
        auto2.Anio = 2018;
        
        // muestra informacion de cada auto
        auto1.MostrarInfo();
        auto2.MostrarInfo();
    }
}