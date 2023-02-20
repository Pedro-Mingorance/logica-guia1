using System;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
        int mt, mc, md, pmc, pmd;

        Console.WriteLine("Ingrese los metros totales del predio:");
        mt = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese los metros cubiertos del predio:");
        mc = int.Parse(Console.ReadLine());
        
        md = mt -mc;
        pmc = mc * 100 / mt;
        pmd = md * 100 / mt;
        
        Console.WriteLine("El porcentaje de metros cubiertos es: " + pmc + " y el porcentaje de metros descubiertos es: " + pmd);
        }
    }
}
