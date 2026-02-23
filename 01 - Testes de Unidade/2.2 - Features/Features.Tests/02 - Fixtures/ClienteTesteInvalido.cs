namespace Features.Tests;

[Collection(nameof(ClienteCollection))]
public class ClienteTesteInvalido(ClienteTestsFixture clienteTestsFixture)
{

    [Fact(DisplayName = "Novo Cliente Inválido")]
    [Trait("Categoria", "Cliente Fixture Testes")]
    public void Cliente_NovoCliente_DeveEstarInvalido()
    {
        // Arrange
        var cliente = clienteTestsFixture.GerarClienteInValido();

        // Act
        var result = cliente.EhValido();

        // Assert 
        Assert.False(result);
        Assert.NotEqual(0, cliente.ValidationResult.Errors.Count);
    }
}