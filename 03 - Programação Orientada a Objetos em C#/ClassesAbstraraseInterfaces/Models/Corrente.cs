namespace ClassesAbstraraseInterfaces.Models
{
    public class Corrente : Conta
    {
        public string NumeroConta { get; set; }
        
        
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        }
    }
}