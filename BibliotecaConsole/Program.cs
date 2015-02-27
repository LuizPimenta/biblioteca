using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClassLibrary.Entity;

namespace BibliotecaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Categoria objCategoria = new Categoria();

            Console.WriteLine("Nome da Categoria: ");
            objCategoria.Nome = Console.ReadLine();

            Console.WriteLine("Categoria:" + objCategoria.Nome);



            Usuario objUsuario = new Usuario();

            Console.WriteLine("Digite o nome do Usuario: ");
            objUsuario.Nome = Console.ReadLine();

            Console.WriteLine("Usuario:" + objUsuario.Nome);

        }
    }
}
