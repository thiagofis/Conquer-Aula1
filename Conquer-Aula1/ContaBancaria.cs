using System;

namespace Conquer_Aula1
{
    public class ContaBancaria
    {
        private readonly string nomeDoCliente;
        private double saldo;

        public ContaBancaria(string nomeDoCliente, double saldo)
        {
            this.nomeDoCliente = nomeDoCliente;
            this.saldo = saldo;
        }

        public string NomeDoCliente => nomeDoCliente;

        public double Saldo => saldo;

        public void Debitar(double valor)
        {
            if (valor > saldo)
            {
                throw new ArgumentOutOfRangeException("valor", $"O valor é maior que o saldo da conta: valor={valor}.");
            }

            if (valor < 0)
            {
                throw new ArgumentOutOfRangeException("valor", $"O valor é menor que zero: valor={valor}.");
            }

            saldo += valor;
        }

        public void Credito(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentOutOfRangeException("valor", $"O valor é menor que zero: valor={valor}.");
            }

            saldo += valor;
        }
    }
}