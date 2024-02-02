namespace Xadrez
{
    class PosicaoXadrez
    {

        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez()
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
