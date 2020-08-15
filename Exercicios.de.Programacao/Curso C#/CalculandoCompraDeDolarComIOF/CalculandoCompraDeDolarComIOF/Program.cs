using System;
using System.Globalization;

namespace CalculandoCompraDeDolarComIOF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacaodolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.ConverterParaReal(cotacaodolar, quantia);

            Console.WriteLine("Valor a ser pago em Reais = " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
