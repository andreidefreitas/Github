using System;
using System.Collections.Generic;
using System.Globalization;

namespace RegistroDeFuncionarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários você deseja cadastrar? ");
            int qtde = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 0; i <= qtde; i++)
            {
                Console.WriteLine("Funcionário: #" + (i + 1) + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());

                list.Add(new Funcionario(id, nome, salario));       //Instaciando uma lista de classe

                Console.WriteLine();
            }
            Console.WriteLine("Entre com o id do empregado");

        }
    }
}
