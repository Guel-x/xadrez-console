using System;
using tabuleiro;

namespace Xadrez
{
    class Rei: Peca
    {

        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "R";
        }
        
        private bool podeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor;
        }
        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[tab.linhas, tab.colunas];
            
            Posicao pos = new Posicao(0, 0);

            // acima
            pos.definirValores(posicao.Linhas - 1, posicao.Colunas);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }
            //ne
            pos.definirValores(posicao.Linhas - 1, posicao.Colunas + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }
            //direita
            pos.definirValores(posicao.Linhas, posicao.Colunas + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }
            //se
            pos.definirValores(posicao.Linhas + 1, posicao.Colunas + 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }
            //abaixo
            pos.definirValores(posicao.Linhas + 1, posicao.Colunas );
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }
            //so
            pos.definirValores(posicao.Linhas + 1, posicao.Colunas - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }
            //esquerda
            pos.definirValores(posicao.Linhas, posicao.Colunas - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }
            //no
            pos.definirValores(posicao.Linhas - 1, posicao.Colunas - 1);
            if (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
            }
            return mat;

        }
    }
}
