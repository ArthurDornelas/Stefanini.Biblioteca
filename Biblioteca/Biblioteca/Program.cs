using System;
using Biblioteca.Model;

namespace Biblioteca
{

    class Program
    {
        private static Library Biblioteca = new Library();
        static void Main(string[] args)
        {
            Biblioteca.Nome = "Bibli";
            Menu();
        }

        private static void Menu()
        {
            int cod = -1;
            while (cod != 0)
            {
                Console.WriteLine("-------------MENU---------------");
                Console.WriteLine("Digite 1 Para Adicionar Um Livro");
                Console.WriteLine("Digite 2 Para Listar Livros");
                Console.WriteLine("Digite 0 Para Sair");

                cod = Convert.ToInt32(Console.ReadLine());
                switch (cod)
                {
                    case 1:
                        AddLivro();
                        break;
                    case 2:
                        ListarLivros();
                        break;
                }
            }
        }

        private static void AddLivro()
        {
            Console.WriteLine("Digite o Numero da Estante do Livro");
            int NumeroEst = Convert.ToInt32(Console.ReadLine());
            Estante Est = new Estante();
            Est.Numero = NumeroEst;
            Biblioteca.Estantes.Add(Est);

            Console.WriteLine("Digite o Numero da Pratileira do Livro");
            int NumeroPrat = Convert.ToInt32(Console.ReadLine());
            Prateleira Prat = new Prateleira();
            Prat.Numero = NumeroPrat;
            Est.Prateleiras.Add(Prat);

            Console.WriteLine("Digite o Nome do Livro");
            Livro Book = new Livro();
            Book.Titulo = Console.ReadLine();

            Console.WriteLine("Digite a Categoria do Livro");
            CategoriaLivro Cat = new CategoriaLivro();
            Cat.Nome = Console.ReadLine();
            Book.Categoria = Cat;

            Console.WriteLine("Digite o Autor do Livro");
            AutorLivro Aut = new AutorLivro();
            Aut.Nome = Console.ReadLine();
            Book.Autor = Aut;

            Prat.Livros.Add(Book);

        }

        private static void ListarLivros()
        {
            Biblioteca.ListarLivros();
        }

       
    }
}
