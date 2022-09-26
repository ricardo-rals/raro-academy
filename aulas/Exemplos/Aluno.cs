namespace Exemplos {
    public class Aluno
    {
        public static bool resultadoFinal(int[] notas)
        {
            int soma = 0;

            foreach(int nota in notas){
                soma += nota;
            }

            if(soma >= 60)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}