using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JogoTeste
{
    [TestClass]
    public class TesteJogo
    {
        [TestMethod]
        public void TesteJogarEmUmaPosicaoVazia()
        {
            JogoDaVelha jogo = new JogoDaVelha();
            Status status = jogo.Jogar(Jogador.X, 0, 0);

            Assert.AreEqual(Status.VALIDO, status);
        }
        [TestMethod]
        public void TestJogarEmUmaPosicaoOcupada()
        {
            JogoDaVelha jogo = new JogoDaVelha();
            jogo.Jogar(Jogador.X, 0, 0);
            Status status = jogo.Jogar(Jogador.O, 0, 0);

            Assert.AreEqual(Status.INVALIDO, status);
        }

        [TestMethod]
        public void TestJogarEmUmaPosicaoInexistente()
        {
            JogoDaVelha jogo = new JogoDaVelha();

            Status status = jogo.Jogar(Jogador.O, 150, 30);

            Assert.AreEqual(Status.INVALIDO, status);
        }

        [TestMethod]
        public void TestVencerNaHorizontal()
        {
            JogoDaVelha jogo = new JogoDaVelha();
            jogo.Jogar(Jogador.X, 0, 0);
            jogo.Jogar(Jogador.X, 0, 1);

            Status status = jogo.Jogar(Jogador.X, 0, 2);

            Assert.AreEqual(Status.VENCEU, status);
        }


        [TestMethod]
        public void TestVencerNaVertical()
        {
            JogoDaVelha jogo = new JogoDaVelha();
            jogo.Jogar(Jogador.X, 0, 2);
            jogo.Jogar(Jogador.X, 1, 2);

            Status status = jogo.Jogar(Jogador.X, 2, 2);

            Assert.AreEqual(Status.VENCEU, status);
        }

        [TestMethod]
        public void TestVencerPelaDiaognalEsquerdaDireita()
        {
            JogoDaVelha jogo = new JogoDaVelha();
            jogo.Jogar(Jogador.X, 0, 0);
            jogo.Jogar(Jogador.X, 1, 1);

            Status status = jogo.Jogar(Jogador.X, 2, 2);

            Assert.AreEqual(Status.VENCEU, status);
        }

        [TestMethod]
        public void TestVencerPelaDiaognalDireitaEsquerda()
        {
            JogoDaVelha jogo = new JogoDaVelha();
            jogo.Jogar(Jogador.X, 0, 2);
            jogo.Jogar(Jogador.X, 1, 1);

            Status status = jogo.Jogar(Jogador.X, 2, 0);

            Assert.AreEqual(Status.VENCEU, status);
        }

        [TestMethod]
        public void TestVelha()
        {
            JogoDaVelha jogo = new JogoDaVelha();
            jogo.Jogar(Jogador.X, 0, 0);
            jogo.Jogar(Jogador.O, 0, 1);
            jogo.Jogar(Jogador.X, 0, 2);

            jogo.Jogar(Jogador.O, 1, 0);
            jogo.Jogar(Jogador.X, 1, 0);
            jogo.Jogar(Jogador.O, 1, 2);

            jogo.Jogar(Jogador.X, 2, 2);
            jogo.Jogar(Jogador.O, 2, 0);
         
            Status status = jogo.Jogar(Jogador.X, 2, 1);

            Assert.AreEqual(Status.EMPATOU, status);
        }
    }
}