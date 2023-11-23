namespace calculadora_imc_xunit;

public class UnitTest1
{
    [Fact]
    public void Teste_Calculo_IMC()
    {
        double imc_previsto = 31.25;
        IMC i = new IMC();
        i.peso = 80;
        i.altura = 1.60;
        i.Calcular_IMC();
        Assert.Equal(imc_previsto, i.imc);
    }

    [Theory]
    [InlineData("Abaixo do peso")]
    [InlineData("Peso normal")]
    [InlineData("Sobrepeso")]
    [InlineData("Obesidade Grau I")]
    [InlineData("Obesidade Grau II")]
    [InlineData("Obesidade Grau III")]
    [InlineData("Digite um valor válido, o IMC não atende os valores digitados")]
    public void Teste_Categoria_IMC(String cat)
    {
        IMC i = new IMC();
        i.peso = 80;
        i.altura = 1.60;
        i.Calcular_IMC();
        i.Classificar_IMC();
        Assert.Equal(i.categoria, cat);
    }
}