using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppTeste01.Modelos
{
    [Table("Carga")]
    class Carga
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Invernada { get; set; }
        public string Fazenda { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
        public int Quantidade { get; set; }
        public string TipoOperacao { get; set; }
        public string Sexo { get; set; }
        public int Total { get; set; }
    }
}
