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
                Console.WriteLine("Digite o codigo do Menu");
                Console.WriteLine("Digite 1 para adicionar um livro");
                Console.WriteLine("Digite 2 para listar livros");
                

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
            Console.WriteLine("Digite o numero da estante do livro");
            int NumeroEst = Convert.ToInt32(Console.ReadLine());
            Estante Est = new Estante();
            Est.Numero = NumeroEst;
            Biblioteca.Estantes.Add(Est);

            Console.WriteLine("Digite o numero da pratileira do livro");
            int NumeroPrat = Convert.ToInt32(Console.ReadLine());
            Prateleira Prat = new Prateleira();
            Prat.Numero = NumeroPrat;
            Est.Prateleiras.Add(Prat);

            Console.WriteLine("Digite o nome do livro");
            Livro Book = new Livro();
            Book.Titulo = Console.ReadLine();

            Console.WriteLine("Digite a categoria do livro");
            CategoriaLivro Cat = new CategoriaLivro();
            Cat.Nome = Console.ReadLine();
            Book.Categoria = Cat;

            Console.WriteLine("Digite o autor do livro");
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
