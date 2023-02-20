using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1, n2, r;

        Console.WriteLine("Por favor ingrese dos numeros separados por la tecla enter:");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        
        r = n1 * n2;
        
        Console.WriteLine("La multiplicacion de los dos numeros antes ingresados da: " + r);
        }
    }
}
