using System;
using System.Collections.Generic;

namespace Matrizes_Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)                         //soma +1 as linhas
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)                     //soma +1 as colunas
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }

                }
            }
            Console.WriteLine("Negative numbers: " + count);
        }
    }
}
