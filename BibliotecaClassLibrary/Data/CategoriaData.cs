using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BibliotecaClassLibrary.Entity;


namespace BibliotecaClassLibrary.Data
{
    internal class CategoriaData:DBConnection
    {
        internal CategoriaData(string strConn) : base(strConn) { }
        internal void Create(Categoria e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Categoria values (@nome)";
            cmd.Parameters.AddWithValue("@nome", e.Nome);
            cmd.ExecuteNonQuery();
        }

        internal void update(Categoria e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update Categoria set nome = @nome where id = @id";
            cmd.Parameters.AddWithValue("@id", e.IdCategoria);
            cmd.Parameters.AddWithValue("@Nome", e.Nome);
            cmd.ExecuteNonQuery();       
        }

    }
}