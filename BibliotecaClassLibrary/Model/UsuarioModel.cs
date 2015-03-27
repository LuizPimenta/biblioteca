using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClassLibrary.Entity;
using BibliotecaClassLibrary.Data;

namespace BibliotecaClassLibrary.Model
{
    public class UsuarioModel
    {
        private string strConn;
        public UsuarioModel(string strConn)
        {
            this.strConn = strConn;   
        }

        public void Create(Usuario e)
        {
            using (UsuarioData data = new UsuarioData(strConn))
            {
                data.Create(e);
            }
        }
        public void Update(Usuario e)
        {
            using (UsuarioData data = new UsuarioData(strConn))
            {
                data.Update(e);
            }
        }

        public void Delete(int id)
        {
            using (UsuarioData data = new UsuarioData(strConn))
            {
                data.Delete(id);
            }
        }

        public Usuario Read(int id)
        {
            using (UsuarioData data = new UsuarioData(strConn))
            {
                return data.Read(id);
            }
        }

        public List<Usuario> Read()
        {
            using (UsuarioData data = new UsuarioData(strConn))
            {
                return data.Read();
            }
        }

    }
}
