using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace cliente.Model
{

    [Table("T_Cliente")]
    class Cliente
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Nombre { get; set; }

    }
}
