using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
namespace cliente.Model
{
    class Conexion
    {

        readonly SQLiteConnection conexion;
        public Conexion(string thePath) {
            conexion = new SQLiteConnection(thePath);
            conexion.CreateTable<Cliente>();
        }

        public int CreateCliente(Cliente nuevo)
        {
            return conexion.Insert(nuevo);
        }

        public List<Cliente> LeerDatos()
        {
            return conexion.Table<Cliente>().ToList();
        }
    }
}
