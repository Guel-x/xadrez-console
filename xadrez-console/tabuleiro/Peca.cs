﻿namespace tabuleiro
{
    class Peca
    {

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qtaMovimento { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qtaMovimento = 0;
        }

        public void incrementoQteMovimento()
        {
            qtaMovimento++;
        }
    }
}
