namespace Demo.Tests;

public class CalculadoraTests
{
    [Fact]
    public void Somar_DeveRetornarSomaDosNumeros()
    {
        // Arrange
        var calculadora = new Calculadora();
        double a = 5;
        double b = 3;
        // Act
        double resultado = calculadora.Somar(a, b);
        // Assert
        Assert.Equal(8, resultado);
    }

    [Theory]
    [InlineData(2, 3, 5)]
    [InlineData(-1, 1, 0)]
    [InlineData(10, 0, 10)]
    public void Somar_DeveRetornarValoresSomaCorretos(int a, int b, int resultadoEsperado)
    {
        // Arrange
        var calculadora = new Calculadora();
        // Act
        double resultado = calculadora.Somar(a, b);
        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
}
