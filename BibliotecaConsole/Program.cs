using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaClassLibrary.Entity;
using BibliotecaClassLibrary.Model;

namespace BibliotecaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string strConn = System.Configuration.ConfigurationSettings.AppSettings["strConn"];

            string op = "":
            do
            {
                Console.WriteLine("Digite a opção: ");
                op = Console.ReadLine();

                switch (op)
                {
                    case "incluir categoria":
                        {
                            Categoria c = new Categoria();

                            Console.WriteLine("Digite o nome:");
                            c.Nome = Console.ReadLine();

                            CategoriaModel model = new CategoriaModel(strConn);
                            model.Create(c);

                        }
                        break;

                    case "listar categoria":
                        {
                            CategoriaModel model = new CategoriaModel(strConn);
                            List<Categoria> lista = model.Read();

                            foreach (Categoria c in lista)
                            {
                                Console.WriteLine(c.IdCategoria);
                                Console.WriteLine(c.Nome);
                                Console.WriteLine("");
                            }

                        }
                        break;

                    case "incluir autor":
                        {
                            Autor a = new Autor();

                            Console.WriteLine("Digite o nome:");
                            a.Nome = Console.ReadLine();

                            AutorModel model = new AutorModel(strConn);
                            model.Create(a);
                        }
                        break;

                    case "listar autor":
                        {
                            AutorModel model = new AutorModel(strConn);
                            List<Autor> lista = model.Read();
                            foreach (Autor a in lista)
                            {
                                Console.WriteLine(a.IdAutor);
                                Console.WriteLine(a.Nome);
                                Console.WriteLine("");
                            }
                        }
                        break;

                    case "incluir usuario":
                        {
                            Usuario u = new Usuario();
                            Console.WriteLine("Digite o nome:");
                            u.Nome = Console.ReadLine();
                            Console.WriteLine("Digite o Email:");
                            u.Email = Console.ReadLine();
                            Console.WriteLine("Digite a senha:");
                            u.Senha = Console.ReadLine();

                            UsuarioModel model = new UsuarioModel(strConn);
                            model.Create(u);
                        }
                        break;

                    case "listar usuario":
                        {
                            UsuarioModel model = new UsuarioModel(strConn);
                            List<Usuario> lista = model.Read();
                            foreach (Usuario u in lista)
                            {
                                Console.WriteLine(u.IdUsuario);
                                Console.WriteLine(u.Nome);
                                Console.WriteLine(u.Email);
                                Console.WriteLine(u.Senha);
                                Console.WriteLine("");
                            }
                        }
                        break;

                    case "incluir livro":
                        {
                            Livro l = new Livro();
                            Console.WriteLine("Digite o titulo:");
                            l.Titulo = Console.ReadLine();
                            Console.WriteLine("Digite e Editora:");
                            l.Editora = Console.ReadLine();
                            Console.WriteLine("Digite a categoria:");
                            l.IdCategoria = int.Parse(Console.ReadLine());
                            Console.WriteLine("Digite o usuario:");
                            l.IdUsuario = int.Parse(Console.ReadLine());

                            LivroModel model = new LivroModel(strConn);
                            model.Create(l);
                        }
                        break;

                    case "listar livro":
                        {
                            LivroModel model = new LivroModel(strConn);
                            List<Livro> lista = model.Read();
                            foreach (Livro l in lista)
                            {
                                Console.WriteLine(l.IdLivro);
                                Console.WriteLine(l.Titulo);
                                Console.WriteLine(l.Editora);
                                Console.WriteLine(l.IdCategoria);
                                Console.WriteLine(l.IdUsuario);
                                Console.WriteLine("");
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Comando não reconhecido");
                        break;
                
                
                }


            } while (op != "sair");
        }
    }
}
