using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    public class CategoriaLivro
    {
        public string Nome { get; set; }

        public string getNome()
        {
            if (this.Nome == "suspense")
                return this.Nome.ToUpper();
            return this.Nome;
        }

    }  
               
}
