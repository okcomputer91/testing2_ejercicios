using System;

// definicion de clase CuentaBancaria
class CuentaBancaria
{
    // Propiedades
    public string Titular { get; set; } // puede leerse y modificarse
    public decimal Saldo { get; private set; } // solo puede modificarse desde la clase
    
    // metodo para depositar dinero
    public void Depositar(decimal monto)
    {
        if (monto > 0) // se valida que el monto sea positivo
        {
            Saldo += monto; // sumamos al saldo
            Console.WriteLine($"Deposito de {monto} realizado.");
        }
        else
        {
            Console.WriteLine("El monto debe ser positivo"); // mensaje de error
        }
    }
    
    // metodo para mostrar el saldo
    public void MostrarSaldo()
    {
        Console.WriteLine($"Saldo actual de {Titular}: {Saldo}"); // muestra saldo
    }
}

class Program
{
    static void Main()
    {
        // creaccion de cuenta bancariia
        CuentaBancaria cuenta = new CuentaBancaria { Titular = "Daniela Garcia" };
        
        // hacer dos depositos
        cuenta.Depositar(10230); // Depositamos 
        cuenta.MostrarSaldo(); //  saldo
        
        cuenta.Depositar(5000); // Depositamos
        cuenta.MostrarSaldo(); //  saldo actualizado
    }
}