using static System.Console;
namespace CelApp.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : SmartPhone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public Iphone(string numero, string model, string imei, int memoria) : base(numero, model, imei, memoria)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            WriteLine($"Instalando {nomeApp} no Iphone...");
        }
    }
}