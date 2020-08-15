//Funcoes auxiliares
using System;
using System.Globalization;

namespace CalculandoCircunferenciaEVolumeDeUmaEsfera
{
    class Program
    {
        static double PI = 3.14;

        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + PI.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circunferencia(double r)
        {
            return 2.0 * PI * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * PI * Math.Pow(r, r);
        }
    }
}
