using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testes
{
    [TestClass]
    public class ValidacaoSenhaTest
    {
        [TestMethod]
        public void TestTemNoMinimo8Caracteres()
        {
            Assert.AreEqual(false, ValidadorDeSenha.validarTamanhosenha(""));
            Assert.AreEqual(false, ValidadorDeSenha.validarTamanhosenha("1234"));
            Assert.AreEqual(false, ValidadorDeSenha.validarTamanhosenha("1234567"));
            Assert.AreEqual(true, ValidadorDeSenha.validarTamanhosenha("12345678"));
            Assert.AreEqual(true, ValidadorDeSenha.validarTamanhosenha("123456789asaf"));
        }

        [TestMethod]
        public void TestTemletraMaiuscula()
        {
            Assert.AreEqual(false, ValidadorDeSenha.validarAoMenosUmaLetraMaiuscula("1231414"));
            Assert.AreEqual(false, ValidadorDeSenha.validarAoMenosUmaLetraMaiuscula("1234ssada"));
            Assert.AreEqual(false, ValidadorDeSenha.validarAoMenosUmaLetraMaiuscula("123456aasas!@#7"));
            Assert.AreEqual(true, ValidadorDeSenha.validarAoMenosUmaLetraMaiuscula("12345678aasdasdD"));
            Assert.AreEqual(true, ValidadorDeSenha.validarAoMenosUmaLetraMaiuscula("DDDDDDDDD"));
        }

              [TestMethod]
        public void TestTemNumero()
        {
            Assert.AreEqual(true, ValidadorDeSenha.validarAoMenosUmNumero("1231414"));
            Assert.AreEqual(true, ValidadorDeSenha.validarAoMenosUmNumero("1234ssada"));
            Assert.AreEqual(true, ValidadorDeSenha.validarAoMenosUmNumero("123456aasas!@#7"));
            Assert.AreEqual(true, ValidadorDeSenha.validarAoMenosUmNumero("12345678aasdasdD"));
            Assert.AreEqual(false, ValidadorDeSenha.validarAoMenosUmNumero("DDDDDDDDD"));
        }
    }
}