namespace tabuleiro
{
    class Tabuleiro
    {

        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        public Peca p(int linhas, int colunas)
        {
            return pecas[linhas, colunas];
        }

        public void colocarPecas(Peca p, Posicao pos)
        {
            pecas[pos.Linhas, pos.Colunas] = p;
            p.posicao = pos;
        }
    }
}
