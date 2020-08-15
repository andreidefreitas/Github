using System;
using System.Collections.Generic;
using System.Text;

namespace AppTeste01.Modelos
{
    class Usuario
    {
        public int Id { get; set; }

        public static string Nome => "Admin";
        public static string Senha => "admin";
    }
}
