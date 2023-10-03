using static System.Console; 
namespace CelApp.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : SmartPhone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string model, string imei, int memoria) : base(numero, model, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            WriteLine($"Instalando {nomeApp} no Nokia...");
        }
    }
}