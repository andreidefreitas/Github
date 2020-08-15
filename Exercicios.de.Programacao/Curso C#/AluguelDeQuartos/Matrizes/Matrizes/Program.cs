using System;
using System.Collections.Generic;

namespace Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2,3];

            Console.WriteLine(mat.Length);      //quantidade de elementos da matriz

            Console.WriteLine(mat.Rank);        //quantidade de linhas da matriz

            Console.WriteLine(mat.GetLength(0));    //quantidade de elementos da primeira dimensao (quantidade de linhas)

            Console.WriteLine(mat.GetLength(1));    //quantidade de elementos da segunda dimensao (quantidade de colunas)
        }
    }
}
