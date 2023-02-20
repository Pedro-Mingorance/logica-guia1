using System;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
        double mt, mf;

        Console.WriteLine("Ingrese el monto total:");
        mt = double.Parse(Console.ReadLine());

        mf = mt * 0.85;

        Console.WriteLine("el monto final con el descuento del 15% es: " + mf);
        }
    }
}
