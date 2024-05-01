namespace PilhaDinamica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PilhaLivro minhaPilha = new PilhaLivro();
            //minhaPilha.Print();

            Livro livro1 = new Livro("Poeira em alto mar");
            Livro livro2 = new Livro("A volta dos que não foram");
            minhaPilha.Push(livro1);
            minhaPilha.Push(livro2);
            minhaPilha.Pop();
            minhaPilha.Pop();
            minhaPilha.Print();


        }
    }
}
