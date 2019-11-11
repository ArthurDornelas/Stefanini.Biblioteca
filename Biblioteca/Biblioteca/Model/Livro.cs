using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    public class Livro
    {
        public string Titulo { get; set; }
        public AutorLivro Autor { get; set; }
        public CategoriaLivro Categoria { get; set; }

        public Livro()
        {  
            Autor = new AutorLivro();
            Categoria = new CategoriaLivro();
        }

       
    }
}
