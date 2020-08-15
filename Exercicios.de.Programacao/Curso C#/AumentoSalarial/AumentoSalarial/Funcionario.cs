using System;
using System.Globalization;

namespace AumentoSalarial
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            porcentagem = (SalarioBruto * porcentagem) / 100;
            SalarioBruto += porcentagem;
        }

        public override string ToString()
        {
            return Nome
                   + ", $ " + SalarioLiquido().ToString(CultureInfo.InvariantCulture);
        }
    }
}
