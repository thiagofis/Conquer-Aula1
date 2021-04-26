using Xunit;

namespace Conquer_Aula1.TesteUnitario
{
    public class ContaBancariaTestes
    {
        [Fact]
        public void DadoUmValorEmContaBancaria_QuandoRealizadoUmDebito_OSaldoEAtualizado()
        {
            // Arrange - Configurações
            var conta = new ContaBancaria("Thiago Silva", 100);
            var valorADebitar = 30;
            var valorEsperadoEmConta = 70;

            //Act - Ação
            conta.Debitar(valorADebitar);

            //Assert - Validação
            Assert.Equal(valorEsperadoEmConta, conta.Saldo); //Erro proposital aqui!
        }

        [Fact]
        public void DadoUmValorEmContaBancaria_QuandoRealizadoUmCredito_OSaldoEAtualizado()
        {
        }

        [Fact]
        public void DadoUmValorEmContaBancaria_QuandoRealizadoUmDebitoMaiorQueOSaldo_OCreditoEspecialEAcionado()
        {
        }
    }
}