using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Autorizacao
{
    public class ValidadorDeSenha
    {
        public static bool validarTamanhosenha(string senha)
            => senha.Length >= 8;

        public static bool validarAoMenosUmaLetraMaiuscula(string senha)
            => Regex.Match(senha, @"[A-Z]").Success;

        public static bool validarAoMenosUmNumero(string senha)
            => Regex.Match(senha, @"[0-9]").Success;
    }
}