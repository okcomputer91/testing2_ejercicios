using System;

class Program
{
    static void Main()
    {
        decimal saldo = 0; // Variable para el saldo, decimal para dinero
        int opcion; // Variable para guardar la opcion del menu
        
        do // Repetir hasta que elija salir (opcion 3)
        {
            // Mostramos el menu
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1 - Ver saldo");
            Console.WriteLine("2 - Depositar dinero");
            Console.WriteLine("3 - Salir");
            Console.Write("Elija una opcion: ");
            
            opcion = Convert.ToInt32(Console.ReadLine()); // Leemos la opcion que elige el usuario en el menu
            
            switch (opcion) // Evaluamos la opcion
            {
                case 1: // Si elige 1
                    Console.WriteLine($"Saldo actual: {saldo}"); //  muestra como moneda
                    break;
                case 2: // Si elige 2
                    Console.Write("Ingrese monto a depositar: ");
                    decimal monto = Convert.ToDecimal(Console.ReadLine());
                    saldo += monto; // Sumamos al saldo
                    Console.WriteLine($"Deposito exitoso. Nuevo saldo: {saldo}");
                    break;
                case 3: // Si elige 3
                    Console.WriteLine("Saliendo del sistema...");
                    break;
                default: // Si eligió otra cosa
                    Console.WriteLine("opcion incorrecta");
                    break;
            }
        } while (opcion != 3); // Condición para continuar
    }
}