using System;
using System.Threading.Tasks;

namespace Filmes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conteudo retirado do site: https://www.themoviedb.org\n");

            Filme caesAluguel = new Filme();
            caesAluguel.Nome = "Caes de Aluguel";
            caesAluguel.DataLancamento = "1992";
            caesAluguel.Direcao = "Quentin Tarantino, Roger Avary";
            caesAluguel.Orcamento = 10.00000000M;
            caesAluguel.Nota = 81;

            Console.WriteLine("Nome: {0}", caesAluguel.Nome);
            Console.WriteLine("Data de Lancamento: {0}", caesAluguel.DataLancamento);
            Console.WriteLine("Direcao: {0}", caesAluguel.Direcao);
            Console.WriteLine("Orcamento: {0}", caesAluguel.Orcamento);
            Console.WriteLine("Nota: {0}%\n\n", caesAluguel.Nota);

            Filme vingadores = new Filme();
            vingadores.Nome = "Vingadores: Guerra infinita";
            vingadores.DataLancamento = "27 de Abril 2018";
            vingadores.Direcao = "Joe Russo, Anthony Russo, Stephen McFeely, Christopher Markus";
            vingadores.Orcamento = 300.00000000M;
            vingadores.Nota = 83;

            Console.WriteLine("Nome: {0}", vingadores.Nome);
            Console.WriteLine("Data de Lancamento: {0}", vingadores.DataLancamento);
            Console.WriteLine("Direcao: {0}", vingadores.Direcao);
            Console.WriteLine("Orcamento: {0}", vingadores.Orcamento);
            Console.WriteLine("Nota: {0}%\n\n", vingadores.Nota);

            Filme curtindo = new Filme();
            curtindo.Nome = "Curtindo a vida adoidado";
            curtindo.DataLancamento = "11 de Junho 1986";
            curtindo.Direcao = "John Hughes";
            curtindo.Orcamento = 6.00000000M;
            curtindo.Nota = 76;

            Console.WriteLine("Nome: {0}", curtindo.Nome);
            Console.WriteLine("Data de Lancamento: {0}", curtindo.DataLancamento);
            Console.WriteLine("Direcao: {0}", curtindo.Direcao);
            Console.WriteLine("Orcamento: {0}", curtindo.Orcamento);
            Console.WriteLine("Nota: {0}%\n\n", curtindo.Nota);


            Console.ReadKey();
        }
    }
}
