namespace tabuleiro
{
    class Posicao
    {

        public int Linhas { get; set; }
        public int Colunas { get; set; }

        public Posicao(int linha, int coluna)
        {
            this.Linhas = linha;
            this.Colunas = coluna;
        }

        public void definirValores (int linha, int coluna)
        {
            this.Linhas = linha;
            this.Colunas = coluna;
        }
        public override string ToString()
        {
            return Linhas
                + ", "
                + Colunas;
        }

    }
}
