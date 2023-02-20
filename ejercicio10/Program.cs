using System;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1, n2, s, r, d, m;

        Console.WriteLine("Ingrese dos numeros separados por la tecla enter:");
        n1 = int.Parse(Console.ReadLine());
        n2 = int.Parse(Console.ReadLine());

        s = n1 + n2;
        r = n1 - n2;
        d = n1 / n2;
        m = n1 * n2;

        Console.WriteLine("Los resultados son: suma = " + s + ", resta = " + r + ", division = " + d + ", multiplicacion = " + m);
        //Console.WriteLine(s + "-" + r + "-" + d + "-" + m);
        }
    }
}
