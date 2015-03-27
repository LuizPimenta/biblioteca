using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BibliotecaClassLibrary.Entity;

namespace BibliotecaClassLibrary.Data
{
    internal class UsuarioData : DBConnection
    {
        internal UsuarioData(string strConn) : base(strConn) { }
        internal void Create(Usuario e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Usuario values(@nome,@email,@senha)";
            cmd.Parameters.AddWithValue("@nome", e.Nome);
            cmd.Parameters.AddWithValue("@email", e.Email);
            cmd.Parameters.AddWithValue("@senha", e.Senha);
            cmd.ExecuteNonQuery();
        }

        internal void Update(Usuario e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Update Usuario set nome = @nome, email = @email, senha = @senha where idUsuario = @id";
            cmd.Parameters.AddWithValue("@id", e.IdUsuario);
            cmd.Parameters.AddWithValue("@nome", e.Nome);
            cmd.Parameters.AddWithValue("@email", e.Email);
            cmd.Parameters.AddWithValue("@senha", e.Senha);
            cmd.ExecuteNonQuery();
        }

        internal void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = " Delete from Usuario where idUsuario = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }

        internal Usuario Read(int id)
        {
            Usuario u = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from Usuario where idUsuario = @id";
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader= cmd.ExecuteReader();
            if (reader.Read())
            {
                u = new Usuario();
                u.IdUsuario = (int)reader["IdUsuario"];
                u.Nome = (string)reader["Nome"];
                u.Email = (string)reader["Email"];
                u.Senha = (string)reader["Senha"];
            }
            return u;
        }
        internal List<Usuario> Read()
        {
            List<Usuario> lista = new List<Usuario>();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select * from Usuario";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Usuario u = new Usuario();
                u.IdUsuario = (int)reader["IdUsuario"];
                u.Nome = (string)reader["Nome"];
                u.Email = (string)reader["Email"];
                u.Senha = (string)reader["Senha"];
                lista.Add(u);
            }
            return lista;
        
        }

    }
}
