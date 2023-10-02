using static System.Console;
using System;

namespace CelApp.Models
{
    public abstract class SmartPhone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public SmartPhone(string numero)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}