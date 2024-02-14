using System.Reflection.Metadata.Ecma335;
using xadrez_console.tabuleiro;

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

        public Peca peca(int linhas, int colunas)
        {
            return pecas[linhas, colunas];
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.Linhas, pos.Colunas];
        } 

        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }

        public void colocarPecas(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroExceptions("Já existe uma peça nessa posição!");
            }
            pecas[pos.Linhas, pos.Colunas] = p;
            p.posicao = pos;
        }

        public Peca retirarPeca(Posicao pos)
        {
            if (peca(pos) == null)
            {
                return null;
            }
            Peca aux = peca(pos);
            aux.posicao = null;
            pecas[pos.Linhas, pos.Colunas] = null;
            return aux;
        }

        public bool posicaoValida(Posicao pos)
        {
            if (pos.Linhas < 0 || pos.Linhas >= linhas || pos.Colunas < 0 || pos.Colunas >= colunas)
            {
                return false;
            }
            return true;
        }

        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroExceptions("Posição inválida");
            }
        }
    }
}
