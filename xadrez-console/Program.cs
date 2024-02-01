using System;
using tabuleiro;
using xadrez_console;
using Xadrez;
using xadrez_console.tabuleiro;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPecas(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPecas(new Torre(tab, Cor.Azul), new Posicao(1, 2));
                tab.colocarPecas(new Rei(tab, Cor.Branca), new Posicao(0, 9));





                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroExceptions e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
