using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
        double n1, n2, n3, r;

        Console.WriteLine("Ingrese la nota de los tres examenes separadas por la tecla enter:");
        n1 = double.Parse(Console.ReadLine());
        n2 = double.Parse(Console.ReadLine());
        n3 = double.Parse(Console.ReadLine());
        
        r = (n1 + n2 + n3) / 3;
        
        Console.WriteLine("El promedio de las tres notas es:" + r);
        }
    }
}
