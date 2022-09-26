using System.Text.RegularExpressions;
namespace Calculadora
{
    public class CalculadoraDeTexto
    {
        public static int Somar(string numeros)
        {
            if (numeros.Equals(""))
            {
                return 0;
            }

            if (!Regex.IsMatch(numeros, @"^[0-9\+]+$"))
            {
                throw new ArgumentException($"Não é possível somar {numeros}");
            }
            else
            {
                return numeros.Split("+")
                                .Select(numero => int.Parse(numero))
                                .Sum();
            }

        }
    }
}
