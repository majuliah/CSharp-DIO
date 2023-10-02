using static System.Console;

namespace ClassesAbstraraseInterfaces.Models
{
    public abstract class Conta
    {
        //protegido de alterações externas a não ser pelas classes filhas
        protected decimal saldo;

        //quando temos uma classe abstrata, ela só serve para ser herdada, e assim é com os métodos, não devemos implementar nada neles, só nas classes que herdarem. é uma assinatura de método somente
        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            WriteLine($"Seu saldo é: {saldo}");
        }
    }
}