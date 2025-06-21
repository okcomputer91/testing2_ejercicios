using System;

class Program
{
    static void Main()
    {
        int suma = 0; // variable para acumular la suma, inicia en 0
        int numero; //variable para guardar cada numero ingresado
        
        Console.WriteLine("Ingrese numeros para sumar (Ingrese 0 para terminar):");
        
        // buucle do-while que se ejecuta al menos una vez
        do
        {
            // Convierte el numero ingresado a num entero
            numero = Convert.ToInt32(Console.ReadLine());
            suma += numero; // Equivalente a: suma = suma + numero
        } while (numero != 0); // Sigue sumando numeros diferents a 0
        
        Console.WriteLine($"Total es: {suma}"); // Muestra suma total
    }
}