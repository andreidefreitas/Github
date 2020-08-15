using System;
using System.Globalization;

namespace OperacoesBancarias_Encapsulamento
{
    class ContaBancaria
    {
        static double taxaSaque = 5.00;

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            this.Numero = numero;
            this.Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            Depositar(depositoInicial);
        }

        //Deposito
        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }
        //Saque
        public void Sacar(double quantia)
        {
            Saldo -= quantia + taxaSaque;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
