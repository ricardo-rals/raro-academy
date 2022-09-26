using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogo
{
    public class JogoDaVelha
    {
        private Jogador[,] Tabuleiro = new Jogador[3, 3];
        private int Movimentos = 0;

        public JogoDaVelha()
        {
            for (int linha = 0; linha < 3; linha++)
            {
                for (int clunha = 0; clunha < 3; clunha++)
                {
                    Tabuleiro[linha, clunha] = Jogador.VAZIO;
                }
            }
        }

        public Status Jogar(Jogador jogador, int linha, int coluna)
        {
            if (foraDoTabuleiro(linha, coluna))
            {
                return Status.INVALIDO;
            }

            if (Tabuleiro[linha, coluna] == Jogador.VAZIO)
            {
                Movimentos++;
                Tabuleiro[linha, coluna] = jogador;

                if (Venceu(jogador))
                {
                    return Status.VENCEU;
                }
                else
                {
                    if (Movimentos == 8)
                    {
                        return Status.EMPATOU;
                    }
                    else
                    {
                        return Status.VALIDO;
                    }
                }
            }
            else
            {
                return Status.INVALIDO;
            }

        }

        private bool Venceu(Jogador jogador) => (venceuPorLinhaOuColuna(jogador) || venceuNaDiagonal(jogador));


        private bool venceuPorLinhaOuColuna(Jogador jogador)
        {
            for (int i = 0; i < 3; i++)
            {
                if (venceuNaHorizontal(i, jogador) || venceuNaVertical(i, jogador))
                {
                    return true;
                }
            }

            return false;
        }

        private bool foraDoTabuleiro(int linha, int coluna) =>
            (linha > 2 || linha < 0 || coluna > 2 || coluna < 0);
        private bool venceuNaHorizontal(int linha, Jogador jogador) =>
            (Tabuleiro[linha, 0] == jogador && Tabuleiro[linha, 1] == jogador && Tabuleiro[linha, 2] == jogador);
        private bool venceuNaVertical(int coluna, Jogador jogador) =>
            (Tabuleiro[0, coluna] == jogador && Tabuleiro[1, coluna] == jogador && Tabuleiro[2, coluna] == jogador);
        private bool venceuNaDiagonal(Jogador jogador) =>
             (Tabuleiro[0, 0] == jogador && Tabuleiro[1, 1] == jogador && Tabuleiro[2, 2] == jogador) ||
            (Tabuleiro[0, 2] == jogador && Tabuleiro[1, 1] == jogador && Tabuleiro[2, 0] == jogador);



    }
}