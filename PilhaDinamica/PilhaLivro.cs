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
            if (Vazia())
                Topo = aux;
            else
            {
                aux.SetAnterior(Topo);
                Topo = aux;
            }
        }
        bool Vazia()
        {
            if (Topo == null)
                return true;
            else
                return false;
        }
        public void InformarListaVazia()
        {
            Console.WriteLine("\nPilha vazia!");
            Console.WriteLine("Pressione qualquer tecla para continuar...\n\n");
            Console.ReadKey();
        }
        public void Print()
        {
            Livro aux = Topo;

            if (Vazia())
                InformarListaVazia();
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
                InformarListaVazia();
            else
                Topo = Topo.GetAnterior();
        }
        public void BuscarLivro(string titulo)
        {
            if (Vazia())
                InformarListaVazia();
            else
            {
                Livro aux = Topo;
                while (titulo != aux.GetTitulo() && aux.GetAnterior() != null)
                {
                    aux = aux.GetAnterior();
                }
                if (aux.GetTitulo() == titulo)
                    Console.WriteLine($"O livro {aux.GetTitulo()} existe na pilha!");
                else
                    Console.WriteLine("O livro não existe na pilha!");

                Console.ReadKey();
            }
        }
    }
}
