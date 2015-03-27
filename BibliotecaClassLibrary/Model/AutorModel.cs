using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClassLibrary.Entity;
using BibliotecaClassLibrary.Data;

namespace BibliotecaClassLibrary.Model
{
    public class AutorModel
    {
        private string strConn;
        public AutorModel(string strConn)
        {
            this.strConn = strConn;
        }

        public void Create(Autor e)
        {
            using(AutorData data = new AutorData(strConn))
            {
                data.Create(e);
            }
        }

        public void Update(Autor e)
        {
            using (AutorData data = new AutorData(strConn))
            {
                data.Update(e);
            }
        }

        public void Delete(int id)
        {
            using (AutorData data = new AutorData(strConn))
            {
                data.Delete(id);
            }
        }
        public Autor Read(int id)
        {
            using (AutorData data = new AutorData(strConn))
            {
                return data.Read(id);
            }
        }

        public List<Autor> Read()
        {
            using (AutorData data = new AutorData(strConn))
            {
                return data.Read();
            }
        }
    }
}
