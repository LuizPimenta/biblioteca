using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClassLibrary.Entity;
using BibliotecaClassLibrary.Data;

namespace BibliotecaClassLibrary.Model
{
    class CategoriaModel
    {
        private string strConn;
        public CategoriaModel(string strConn)
        {
            this.strConn = strConn;
        }

        public void Create(Categoria e)
        {
            using (CategoriaData data = new CategoriaData(strConn))
            { 
                data.Create(e); 
            }
            
        }

        public void Update(Categoria e)
        {
            using (CategoriaData data = new CategoriaData(strConn))
            {
                data.Update(e);
            }

        }
        public void Delete(int id)
        {
            using (CategoriaData data = new CategoriaData(strConn))
            {
                data.Delete(id);
            }

        }

        public Categoria Read(int id)
        {
            using (CategoriaData data = new CategoriaData(strConn))
            {
                return data.Read(id);
            }

        }

        public List<Categoria> Read()
        {
            using (CategoriaData data = new CategoriaData(strConn))
            {
                return data.Read();
            }

        }
    }
}
