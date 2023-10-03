using static System.Console;
using System;

namespace CelApp.Models
{
    public abstract class SmartPhone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        protected string Model { get; set; }
        protected string IMEI { get; set; }
        protected int Memoria { get; set; }

        public SmartPhone(string numero, string model, string imei, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades
            Model = model;
            IMEI = imei;
            Memoria = memoria;
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