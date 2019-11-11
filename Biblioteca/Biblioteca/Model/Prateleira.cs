using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    public class Prateleira
    {
        public static int numPrateleiras = -1;
        public int Numero { get; set; }
        public List<Livro> Livros;

        public Prateleira()
        {
            Livros = new List<Livro>();
        }

        public void ListarLivros()
        {
            foreach (Livro l in Livros)
            {
                Console.WriteLine( "\t\tTitulo: " + l.Titulo + " " + "Categoria: " + l.Categoria.getNome() + " " + "Autor: " + l.Autor.Nome + " ");
            }
        }

    }
}
