using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;
using SQLite;
using AppTeste01.Modelos;

namespace AppTeste01.Banco
{
    class Database
    {
        private SQLiteConnection _conexao;
        public Database()
        {
            var dep = DependencyService.Get<ICaminho>();
            string caminho = dep.ObterCaminho("database.sqlite");

            _conexao = new SQLiteConnection(caminho);
            _conexao.CreateTable<Carga>();
        }

        public List<Carga> Consultar()
        {
            return _conexao.Table<Carga>().ToList();
        }

        public List<Carga> PesquisaPorData(string data)
        {
            return _conexao.Table<Carga>().Where(a => a.Data.Contains(data)).ToList();
        }

        public void Inserir(Carga carga)
        {
            _conexao.Insert(carga);
        }

        public void Atualizar(Carga carga)
        {
            _conexao.Update(carga);
        }

        public void Excluir(Carga carga)
        {
            _conexao.Delete(carga);
        }
    }
}
