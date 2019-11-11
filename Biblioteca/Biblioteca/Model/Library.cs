using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    public class Library
    {
        
        public string Nome { get; set; }
        public List<Estante> Estantes;

        public Library()
        {
            Estantes = new List<Estante>();
        }

        public void ListarLivros()
        {
            Console.WriteLine("Biblioteca: " + Nome);
            foreach (Estante e in Estantes)
            {
                Console.WriteLine("\tEstante: " + e.Numero);
                e.ListarPrateleiras();
            }
        }
    }
}
