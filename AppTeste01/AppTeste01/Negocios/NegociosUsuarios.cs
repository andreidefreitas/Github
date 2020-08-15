using System;
using System.Collections.Generic;
using System.Text;
using AppTeste01.Modelos;

namespace AppTeste01.Negocios
{
    public static class NegociosUsuarios
    {
        public static Boolean ValidaUsuario(string nome, string senha)
        {
            if ((nome == Usuario.Nome.ToString()) && (senha == Usuario.Senha.ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
