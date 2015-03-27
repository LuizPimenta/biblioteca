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

        internal void Update(Categoria e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update Categoria set nome = @nome where idCategoria = @id";
            cmd.Parameters.AddWithValue("@id", e.IdCategoria);
            cmd.Parameters.AddWithValue("@nome", e.Nome);
            cmd.ExecuteNonQuery();       
        }

        internal void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = " Delete from Categoria where idCategoria = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        internal Categoria Read(int id)
        {
            Categoria c = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from Categoria where idCategoria = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                c = new Categoria();
                c.IdCategoria = (int)reader["IdCategoria"];
                c.Nome = (string)reader["Nome"];
                
            }
            return c;
        }
        internal List<Categoria> Read()
        {
            List<Categoria> lista = new List<Categoria>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from Categoria";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Categoria c = new Categoria();
                c.IdCategoria = (int)reader["IdCategoria"];
                c.Nome = (string)reader["Nome"];
                lista.Add(c);
            }
            return lista;

        }

    }
}