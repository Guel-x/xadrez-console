using tabuleiro;

namespace Xadrez
{
    class PartidaXadrez
    {

        public Tabuleiro tab { get; private set; }
        private int turno;
        private Cor jogadorAtual;
        public bool terminada { get; private set; }
        public PartidaXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = Cor.Branca;
            terminada = false;
            colacarPeca();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementoQteMovimento();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPecas(p, destino);
        }

        private void colacarPeca()
        {
            tab.colocarPecas(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 1).toPosicao());
            tab.colocarPecas(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 2).toPosicao());
            tab.colocarPecas(new Torre(tab, Cor.Branca), new PosicaoXadrez('d', 2).toPosicao());
            tab.colocarPecas(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 2).toPosicao());
            tab.colocarPecas(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 1).toPosicao());
            tab.colocarPecas(new Rei(tab, Cor.Branca), new PosicaoXadrez('d', 1).toPosicao());
            
            tab.colocarPecas(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 8).toPosicao());
            tab.colocarPecas(new Torre(tab, Cor.Branca), new PosicaoXadrez('c', 7).toPosicao());
            tab.colocarPecas(new Torre(tab, Cor.Branca), new PosicaoXadrez('d', 7).toPosicao());
            tab.colocarPecas(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 7).toPosicao());
            tab.colocarPecas(new Torre(tab, Cor.Branca), new PosicaoXadrez('e', 8).toPosicao());
            tab.colocarPecas(new Rei(tab, Cor.Branca), new PosicaoXadrez('d', 8).toPosicao());

        }
    }
}
