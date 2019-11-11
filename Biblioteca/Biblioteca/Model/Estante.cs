using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    public class Estante
    {
        public static int numEstantes = -1;
        public int Numero { get; set; }
        public List<Prateleira> Prateleiras;

        public Estante()
        {
            Prateleiras = new List<Prateleira>();
        }

        public void ListarPrateleiras()
        {
            foreach(Prateleira p in Prateleiras)
            {
                Console.WriteLine("\t\tPrateleira: " + p.Numero);
                p.ListarLivros();
            }
        }
    }
}
