using tabuleiro;

namespace Xadrez
{
    class Torre: Peca
    {

        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "T";
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

            //acima
            pos.definirValores(posicao.Linhas - 1, posicao.Colunas);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
                if(tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Linhas = pos.Linhas - 1;
            }
            //abaixo
            pos.definirValores(posicao.Linhas + 1, posicao.Colunas);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                mat[pos.Linhas, pos.Colunas] = true;
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Linhas = pos.Linhas + 1;
            }
            // direita
            pos.definirValores(posicao.Linhas, posicao.Colunas + 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Colunas = pos.Colunas + 1;
            }
            //esquerda
            pos.definirValores(posicao.Linhas, posicao.Colunas - 1);
            while (tab.posicaoValida(pos) && podeMover(pos))
            {
                if (tab.peca(pos) != null && tab.peca(pos).cor != cor)
                {
                    break;
                }
                pos.Colunas = pos.Colunas - 1;
            }
            return mat;
        }
    }
}
