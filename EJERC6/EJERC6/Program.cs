using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERC6
{
    internal class Program
    {
        static double tarifaNormal = 1.80;
        static double tarifaExceso = 2.50;
        static double limiteNormal = 20;
        static void Main(string[] args)
        {
            Console.Write("Ingrese el consumo en m³: ");
            double m3 = double.Parse(Console.ReadLine());

            double costo = CalcularCostoAgua(m3);

            MostrarRecibo(m3, costo);
        }
        static double CalcularCostoAgua(double m3)
        {
            double costo;

            if (m3 <= limiteNormal)
            {
                costo = m3 * tarifaNormal;
            }
            else
            {
                costo = limiteNormal * tarifaNormal + (m3 - limiteNormal) * tarifaExceso;
            }
            return costo;
        }
        static void MostrarRecibo(double m3, double costo)
        {
            Console.WriteLine("\n=== RECIBO DE AGUA ===");
            Console.WriteLine($"Consumo:     {m3} m³");
            Console.WriteLine($"Costo total: S/{costo:F2}");
        }
    }

}
