using Features.Clientes;

namespace Features.Tests;

public class ClienteTests
{
    [Fact(DisplayName = "Novo Cliente Válido")]
    [Trait("Categoria", "Cliente Trait Testes")]
    public void NovoCliente_DeveEstarAtivo()
    {
        // Arrange
        var cliente = new Cliente(
            Guid.NewGuid(),
            "John",
            "Doe",
            DateTime.Now.AddYears(-30),
            "john@teste.com.br",
            true,
            DateTime.Now);

        // Act
        var resultado = cliente.EhValido();

        // Assert
        Assert.True(resultado);
        Assert.Equal(0, cliente.ValidationResult.Errors.Count);
    }

    [Fact(DisplayName = "Novo Cliente Inválido")]
    [Trait("Categoria", "Cliente Trait Testes")]
    public void NovoCliente_DeveEstarInvalido()
    {
        // Arrange
        var cliente = new Cliente(
            Guid.NewGuid(),
            nome: "",
            sobrenome: "",
            dataNascimento: DateTime.Now,
            email: "edu2edu.com",
            ativo: true,
            dataCadastro: DateTime.Now);

        // Act
        var result = cliente.EhValido();

        // Assert
        Assert.False(result);
        Assert.NotEqual(expected: 0, actual: cliente.ValidationResult.Errors.Count);
    }

}
