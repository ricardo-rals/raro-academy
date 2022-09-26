using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testes
{
    [TestClass]
    public class AutorizacaoTest
    {
        [TestMethod]
        public void TestUsuarioValido()
        {
            Usuario lee = new Usuario("lee@rarolabs.com.br", "Teste1234!", "Teste1234!");
            GerenciadorDeUsuarios gerenciador = new GerenciadorDeUsuarios();

            Criterio[] criterio = gerenciador.criar(lee);

            CollectionAssert.AreEqual(new Criterio[] {Criterio.Sucesso}, criterio);
        }

        [TestMethod]
        public void testSenhaInvalida()
        {
            Usuario lee = new Usuario("lee@rarolabs.com.br", "", "");
            GerenciadorDeUsuarios gerenciador = new GerenciadorDeUsuarios();

            Criterio[] atual = gerenciador.criar(lee);
            Criterio[] esperado = new Criterio[] {
                Criterio.TamanhoInvalido,
                Criterio.NaoTemLetraMaiuscula,
                Criterio.NaoTemNumero,
                Criterio.NaoTemCaractereEspecial
            };

            CollectionAssert.AreEqual(esperado, atual);

        }
    }
}