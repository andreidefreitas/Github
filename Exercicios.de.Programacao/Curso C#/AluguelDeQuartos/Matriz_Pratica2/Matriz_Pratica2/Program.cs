using System;
using System.Collections.Generic;

namespace Matriz_Pratica2
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = 

           int[,] mat = new int[M, N];


            for (int i = 0; i < M; i++)
            {
                string[] numbers = new string[i];
                numbers = Console.ReadLine().Split(' ');

                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(numbers[i]);                    
                }
            }

            Console.WriteLine();

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.WriteLine(mat[M,N]);
                }
            }

            Console.WriteLine();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if ((mat[i, j] == number) && (mat[i, j] != null))
                    {
                        Console.WriteLine("Position " + mat[i,j]);
                        Console.Write("Left: " + mat[i-1,j-1]);
                    }
                }
            }
        }
    }
}
