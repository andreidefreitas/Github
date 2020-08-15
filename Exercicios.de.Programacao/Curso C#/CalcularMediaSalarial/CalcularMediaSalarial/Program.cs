using System;
using System.Globalization;

namespace CalcularMediaSalarial
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario Func1, Func2;

            Func1 = new Funcionario();
            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            Func1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            Func1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Func2 = new Funcionario();
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            Func2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            Func2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (Func1.Salario + Func2.Salario) / 2.0;
            Console.WriteLine("Salário Médio: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
