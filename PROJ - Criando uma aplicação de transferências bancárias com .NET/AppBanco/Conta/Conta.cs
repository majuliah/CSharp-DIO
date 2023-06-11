using System.Globalization;
using static System.Console;
using AppBanco.Enums;

namespace AppBanco
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            TipoConta = tipoConta;
            Saldo = saldo;
            Credito = credito;
            Nome = nome;
        }

        public bool Sacar(double valorSaque)
        {
            if (Saldo - valorSaque < (Credito * -1))
            {
                WriteLine($"Saldo insuficiente");
                return false;
            }
            Saldo -= valorSaque;
            WriteLine($"Saldo atual da conta {Nome} é de R${Saldo.ToString($"F2", CultureInfo.InvariantCulture)}");
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            Saldo += valorDeposito;
            WriteLine($"Saldo atual da conta {Nome} é de R${Saldo.ToString($"F2", CultureInfo.InvariantCulture)}");
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }

        public override string ToString()
        {
            return $"Tipo conta: {TipoConta} | " +
                   $"Nome: {Nome} | " +
                   $"Saldo: {Saldo.ToString($"F2", CultureInfo.InvariantCulture)} | " +
                   $"Crédito: {Credito.ToString($"F2", CultureInfo.InvariantCulture)} | ";
        }
    }
}