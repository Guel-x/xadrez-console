using System;
using tabuleiro;
using xadrez_console;
using Xadrez;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.colocarPecas(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocarPecas(new Torre(tab, Cor.Azul), new Posicao(1, 2));
            tab.colocarPecas(new Rei(tab, Cor.Branca), new Posicao(2, 4));
            



            Tela.imprimirTabuleiro(tab);
            Console.ReadLine();

        }
    }
}
