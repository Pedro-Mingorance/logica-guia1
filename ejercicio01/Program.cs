using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1, n2, r;

        Console.WriteLine("Ingrese un numero y luego otro separados por la tecla enter");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        
        r = n1 + n2;
        
        Console.WriteLine("El resultado de la suma de los dos numeros es: " + r);
        }
    }
}
