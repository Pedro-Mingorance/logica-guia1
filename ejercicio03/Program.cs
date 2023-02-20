using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1, n2, r;

        Console.WriteLine("Ingrese el año actual y luego su año de nacimiento separados por la tecla enter:");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());
        
        r = n1 - n2;
        
        Console.WriteLine("Su edad al finalizar este año es: " + r);
        }
    }
}
