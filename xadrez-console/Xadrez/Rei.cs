using tabuleiro;

namespace Xadrez
{
    class Rei: Peca
    {

        private PartidaXadrez partida;

        public Rei(Tabuleiro tab, Cor cor, PartidaXadrez partida) : base(tab, cor)
        {
            this.partida = partida;
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

        private bool testeTorreParaRoque(Posicao pos)
        {
            Peca p = tab.peca(pos); ;
            return p != null && p is Torre && p.cor == cor && p.qtaMovimento == 0;
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

            // #jogadaespecial roque
            if (qtaMovimento == 0 && !partida.xeque)
            {
                //#jogadaespecial roque pequeno
                Posicao posT1 = new Posicao(posicao.Linhas, posicao.Colunas + 3);
                if (testeTorreParaRoque(posT1))
                {
                    Posicao p1 = new Posicao(posicao.Linhas, posicao.Colunas + 1);
                    Posicao p2 = new Posicao(posicao.Linhas, posicao.Colunas + 2);
                    if(tab.peca(p1)== null && tab.peca(p2)== null)
                    {
                        mat[posicao.Linhas, pos.Colunas + 2] = true;
                    }
                }

                //#jogadaespecial roque grande
                Posicao posT2 = new Posicao(posicao.Linhas, posicao.Colunas - 4);
                if (testeTorreParaRoque(posT2))
                {
                    Posicao p1 = new Posicao(posicao.Linhas, posicao.Colunas - 1);
                    Posicao p2 = new Posicao(posicao.Linhas, posicao.Colunas - 2);
                    Posicao p3 = new Posicao(posicao.Linhas, posicao.Colunas - 3);

                    if (tab.peca(p1) == null && tab.peca(p2) == null && tab.peca(p3) == null) 
                    {
                        mat[posicao.Linhas, pos.Colunas - 2] = true;
                    }
                }
            }


            return mat;

        }
    }
}
