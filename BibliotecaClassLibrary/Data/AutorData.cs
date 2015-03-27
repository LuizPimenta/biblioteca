using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BibliotecaClassLibrary.Entity;


namespace BibliotecaClassLibrary.Data
{
    internal class AutorData : DBConnection
    {
        internal AutorData(string strConn) : base(strConn) { }
        internal void Create(Autor e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Autor values (@nome)";
            cmd.Parameters.AddWithValue("@nome", e.Nome);
            cmd.ExecuteNonQuery();
        }

        internal void Update(Autor e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update Autor set nome = @nome where idAutor = @id";
            cmd.Parameters.AddWithValue("@id", e.IdAutor);
            cmd.Parameters.AddWithValue("@nome", e.Nome);
            cmd.ExecuteNonQuery();
        }

        internal void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = " Delete from Autor where idAutor = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        internal Autor Read(int id)
        {
            Autor a = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from Autor where idAutor = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                a = new Autor();
                a.IdAutor = (int)reader["IdAutor"];
                a.Nome = (string)reader["Nome"];

            }
            return a;
        }
        internal List<Autor> Read()
        {
            List<Autor> lista = new List<Autor>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from Autor";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Autor a = new Autor();
                a.IdAutor = (int)reader["IdAutor"];
                a.Nome = (string)reader["Nome"];
                lista.Add(a);
            }
            return lista;

        }
    }
}