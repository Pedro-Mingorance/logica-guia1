using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
        double tf, tac;

        Console.WriteLine("Ingrese el total facturado:");
        tf = double.Parse(Console.ReadLine());
        
        tac = tf * 0.05 + 15000;
        
        Console.WriteLine("El total a cobrar es: " + tac);
        }
    }
}
