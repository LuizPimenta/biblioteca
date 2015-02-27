using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassLibrary.Entity
{
    public class Autor
    {
        #region Campos
        private int idAutor;
        private string nome;
        #endregion

        #region Propriedades
        public int IdAutor
        {
            get { return idAutor; }
            set { idAutor = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        #endregion

    }
}


// EXERCICIO FEITO DIA 20/02/2015