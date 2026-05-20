class Program
{
    // Calcula el sueldo bruto multiplicando horas por pago por hora 
    static double CalcularBruto(double horas)
    {
        return horas * 12.50;
    }

    // Calcula el descuento del 5% 
    static double CalcularDescuento(double bruto)
    {
        return bruto * 0.05;
    }

    // Calcula el sueldo neto restando el descuento al sueldo bruto 
    static double CalcularNeto(double bruto, double descuento)
    {
        return bruto - descuento;
    }

    static void Main(string[] args)
    {
        Console.Write("Horas trabajadas: ");
        double horas = double.Parse(Console.ReadLine());

        // Llamadas a las funciones 
        double bruto = CalcularBruto(horas);
        double descuento = CalcularDescuento(bruto);
        double neto = CalcularNeto(bruto, descuento);

        Console.WriteLine("\n=== BOLETA DE SUELDO ===");
        Console.WriteLine($"Sueldo bruto: S/ {bruto:F2}");
        Console.WriteLine($"Descuento (5%): S/ {descuento:F2}");
        Console.WriteLine($"Sueldo neto: S/ {neto:F2}");
    }
}