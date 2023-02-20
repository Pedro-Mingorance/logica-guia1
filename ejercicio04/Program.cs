using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
        double n1, n2, r;

        Console.WriteLine("Ingrese los kilometros entre las ciudades a recorrer:");
        n1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la velocidad promedio del vehiculo");
        n2 = double.Parse(Console.ReadLine());
        
        r = n1 / n2;
        
        Console.WriteLine("La/s hora/s para recorrer esa distancia va a ser: " + r);
        }
    }
}
