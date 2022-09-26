namespace Testes;
using Exemplos;


[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TesteAprovado()
    {
        int [] notas = {10,30,40,10};
        bool resultado = Aluno.resultadoFinal(notas);
        Assert.AreEqual(true, resultado);
    }
}