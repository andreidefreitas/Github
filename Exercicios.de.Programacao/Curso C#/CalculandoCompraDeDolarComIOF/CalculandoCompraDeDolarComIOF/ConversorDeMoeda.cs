using System;
using System.Globalization;

namespace CalculandoCompraDeDolarComIOF
{
    class ConversorDeMoeda
    {
        static double Iof = 6.0;

        public static double DolarParaReal(double cotacaodolar, double qtdecompra)
        {
            double valoremreal = qtdecompra * cotacaodolar;
            return valoremreal += ((valoremreal * Iof) / 100);
        }
    }
}
