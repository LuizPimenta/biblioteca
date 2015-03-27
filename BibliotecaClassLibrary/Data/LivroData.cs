using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BibliotecaClassLibrary.Entity;

namespace BibliotecaClassLibrary.Data
{
    internal class LivroData:DBConnection
    {
        internal LivroData(string strConn) : base(strConn) { }
        internal void Create(Livro e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Livro values (@Titulo,@Editora,@IdCategoria,@IdUsuario)";
            cmd.Parameters.AddWithValue("@Titulo", e.Titulo);
            cmd.Parameters.AddWithValue("@Editora", e.Editora);
            cmd.Parameters.AddWithValue("@IdCategoria", e.IdCategoria);
            cmd.Parameters.AddWithValue("@IdUsuario", e.IdUsuario);
            cmd.ExecuteNonQuery();
        }

        internal void Update(Livro e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update Livro set Titulo = @Titulo, Editora = @Editora, IdCategoria = @IdCategoria, IdUsuario = @IdUsuario where idLivro = @id";
            cmd.Parameters.AddWithValue("@id", e.IdLivro);
            cmd.Parameters.AddWithValue("@Titulo", e.Titulo);
            cmd.Parameters.AddWithValue("@Editora", e.Editora);
            cmd.Parameters.AddWithValue("@IdCategoria", e.IdCategoria);
            cmd.Parameters.AddWithValue("@IdUsuario", e.IdUsuario);
            cmd.ExecuteNonQuery();       
        }

        internal void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = " Delete from Livro where idLivro = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        internal Livro Read(int id)
        {
            Livro c = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from Livro where idLivro = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                c = new Livro();
                c.IdLivro = (int)reader["IdLivro"];
                c.Titulo = (string)reader["Titulo"];
                c.Editora = (string)reader["Editora"];
                c.IdCategoria = (int)reader["IdCategoria"];
                c.IdUsuario = (int)reader["IdUsuario"];
                
            }
            return c;
        }
        internal List<Livro> Read()
        {
            List<Livro> lista = new List<Livro>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from Livro";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Livro c = new Livro();
                c.IdLivro = (int)reader["IdLivro"];
                c.Titulo = (string)reader["Titulo"];
                c.Editora = (string)reader["Editora"];
                c.IdCategoria = (int)reader["IdCategoria"];
                c.IdUsuario = (int)reader["IdUsuario"];
                lista.Add(c);
            }
            return lista;

        }
    }
}
