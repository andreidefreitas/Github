using System;
using System.Globalization;

namespace MediaAlunos
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
           return (Nota1 + Nota2 + Nota3);
        }
    }
}
