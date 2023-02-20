using System;

namespace ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            float m, h, t, pm, ph;

            Console.WriteLine("Ingrese primero la cantidad de mujeres y luego la cantidad de hombres separados por la tecla enter:");
            m = float.Parse(Console.ReadLine());
            h = float.Parse(Console.ReadLine());

            t = m + h;
            pm = m * 100 / t;
            ph = h * 100 / t;

            Console.WriteLine("El porcentaje de mujeres es: " + pm.ToString("N2") + " y el porcentaja de hombres es: " + ph.ToString("N2"));
        }
    }
}
