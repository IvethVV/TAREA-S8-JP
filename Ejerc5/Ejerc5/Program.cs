using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc5
{
    internal class Program
    {
        static double notaMinima = 0;
        static double notaMaxima = 20;
        static void Main(string[] args)
        {
            Console.Write("Ingrese la nota final: ");
            double nota = double.Parse(Console.ReadLine());

            bool valida = EsNotaValida(nota);

            if (valida)
            {
                string clasificacion = ClasificarNota(nota);

                MostrarReporte(nota, clasificacion);
            }
            else
            {
                Console.WriteLine("Error: la nota debe estar entre 0 y 20.");
            }
        }
        static bool EsNotaValida(double nota)
        {
            bool resultado = nota >= notaMinima && nota <= notaMaxima;
            return resultado;
        }
        static string ClasificarNota(double nota)
        {
            if (nota >= 18)
            {
                return "Excelente";
            }
            else if (nota >= 14)
            {
                return "Bueno";
            }
            else if (nota >= 11)
            {
                return "Regular";
            }
            else
            {
                return "Desaprobado";
            }
        }
        static void MostrarReporte(double nota, string clasificacion)
        {
            Console.WriteLine("\n=== REPORTE DE NOTA ===");
            Console.WriteLine($"Nota ingresada:  {nota:F2}");
            Console.WriteLine($"Clasificación:   {clasificacion}");
        }
    }
}
