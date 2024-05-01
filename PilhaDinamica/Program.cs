namespace PilhaDinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilhaLivro minhaPilha = new PilhaLivro();
            int opcao = 0;
            do
            {
                Console.Clear();               
                Console.WriteLine(">>> Menu Principal - Pilha de Livros <<<");
                Console.WriteLine("Escolha uma das opções:\n" +
                                  "1 - Inserir Livro;\n" +
                                  "2 - Remover Livro\n" +
                                  "3 - Imprimir Pilha;\n" +
                                  "4 - Buscar Livro na Pilha;\n" +
                                  "0 - Sair");
                opcao = int.Parse(Console.ReadLine());
                
                switch (opcao)
                {
                    case 1:
                        minhaPilha.Push(CadastroLivro());
                        break;
                    case 2:
                        minhaPilha.Pop();
                        break;
                    case 3:
                        minhaPilha.Print();
                        break;
                    case 4:
                        Console.WriteLine("Digite o nome do livro:");
                        minhaPilha.BuscarLivro(Console.ReadLine()); 
                        break;
                    case 0:
                        Console.WriteLine("Fim do Programa;");
                        break;
                    default:
                        Console.WriteLine("Opção inexistente!");
                        break;        
                } 
            } while (opcao != 0);
        }
        static Livro CadastroLivro()
        {
            string titulo;
            Console.WriteLine("Informe o titulo do novo Livro:");
            titulo = Console.ReadLine();
            Livro livro = new Livro(titulo);
            return livro;
        }
    }
}
