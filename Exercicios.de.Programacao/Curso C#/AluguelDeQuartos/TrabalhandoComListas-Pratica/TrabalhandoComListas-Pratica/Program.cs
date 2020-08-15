using System;
using System.Collections.Generic;
namespace TrabalhandoComListas_Pratica
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");

            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');                //Funcao anonima/Lambda x é tal que x[0] seja igual a 'A'
            Console.WriteLine("First A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A: " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');            //encontrar o primeiro index da lista com palavra comecando com a letra A
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);  //filtrar nome com 5 caracteres

            Console.WriteLine("------------------------------------------------------------");
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");            //remove string da lista
            Console.WriteLine("-------------------------------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');            
            Console.WriteLine("-------------------------------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAt(0);            //remove string da lista
            Console.WriteLine("-------------------------------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveRange(0, 1);         //remove (indice, quantidade)
            Console.WriteLine("-------------------------------------------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
