using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClassLibrary.Entity;
using BibliotecaClassLibrary.Data;

namespace BibliotecaClassLibrary.Model
{
    public class LivroModel
    {
        private string strConn;
        public LivroModel(string strConn)
        {
            this.strConn = strConn;
        }

        public void Create(Livro e)
        {
            using (LivroData data = new LivroData(strConn))
            { 
                data.Create(e); 
            }
            
        }

        public void Update(Livro e)
        {
            using (LivroData data = new LivroData(strConn))
            {
                data.Update(e);
            }

        }
        public void Delete(int id)
        {
            using (LivroData data = new LivroData(strConn))
            {
                data.Delete(id);
            }

        }

        public Livro Read(int id)
        {
            using (LivroData data = new LivroData(strConn))
            {
                return data.Read(id);
            }

        }

        public List<Livro> Read()
        {
            using (LivroData data = new LivroData(strConn))
            {
                return data.Read();
            }

        }
    }
}
