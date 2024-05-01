using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaDinamica
{
    internal class PilhaLivro
    {
        Livro Topo;

        public PilhaLivro()
        {
            Topo = null;
        }
        public void Push(Livro aux)
        {
            if (Vazia() == true)
                Topo = aux;
            else
            {
                aux.SetAnterior(Topo);
                Topo = aux;
            }
        }
        Boolean Vazia()
        {
            if (Topo == null)
                return true;
            else
                return false;
        }
        public void Print()
        {
            Livro aux = Topo;

            if (Vazia())
            {
                Console.WriteLine("\nPilha vazia!");
                Console.WriteLine("Pressione qualquer tecla para continuuar...\n\n");
                Console.ReadKey();
            }
            else
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.GetAnterior();
                } while (aux != null);
                Console.WriteLine("\nFim da Impressão");
                Console.WriteLine("Pressione qualquer tecla para continuuar...\n\n");
                Console.ReadKey();
            }
        }
        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("\nPilha vazia! Impossivel remover!");
                Console.WriteLine("Pressione qualquer tecla para continuuar...\n\n");
                Console.ReadKey();
            }
            else
                Topo = Topo.GetAnterior();
        }
    }
}
