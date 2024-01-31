namespace tabuleiro
{
    class Posicao
    {

        public int Linhas { get; set; }
        public int Colunas { get; set; }

        public Posicao(int linha, int colunas)
        {
            this.Linhas = linha;
            this.Colunas = colunas;
        }

        public override string ToString()
        {
            return Linhas
                + ", "
                + Colunas;
        }

    }
}
