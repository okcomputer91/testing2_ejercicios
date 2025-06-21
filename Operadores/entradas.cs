using System;

class Program
{
    static void Main()
    {
        // Pregunta el progrma si tiene entrada
        Console.Write("¿Tiene entrada? (s/n): ");
        // Convertimos la respuesta a un valor booleano (true/false)
        // Si el usuario ingresa "s" (en minuscla o mayusc), tieneEntrada será true
        bool tieneEntrada = Console.ReadLine().ToLower() == "s";
        
        // Pregunta sobre la edad
        Console.Write("Ingrese su edad: ");
        // Convertimos el texto ingresado a un num entero
        int edad = Convert.ToInt32(Console.ReadLine());
        
        // Verificacion de las condiciones para entrar:
        // 1. Si tiene entrada (tieneEntrada == true) O
        // 2. Si es menor de 12 años (edad < 12)
        bool puedeEntrar = tieneEntrada || edad < 12;
        
        // Mostramos el resultado
        if (puedeEntrar)
        {
            Console.WriteLine("Puede entrar al cine");
            
            // Info adicional sobre por que puede entrar
            if (tieneEntrada)
            {
                Console.WriteLine("Motivo: Tiene entrada");
            }
            else
            {
                Console.WriteLine("Motivo: Es menor de 12 años (entrada gratis)");
            }
        }
        else
        {
            Console.WriteLine("No puede entrar al cine");
            Console.WriteLine("Motivo: No tiene entrada y no es menor de 12 años");
        }
    }
}