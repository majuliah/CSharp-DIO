using System;

namespace ManipulandoValores
{
    public class Pessoa
    {
        public Pessoa() { }
 
        private string _nome;
        private int _idade;
        public string Nome
        {
            get => _nome.ToUpper(); 
            set
            {
                if (value == "")
                    throw new ArgumentException("O nome não pode ser vazio.");

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                    throw new AggregateException("Idade não pode ser menor que 0");

                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Meu nome é {NomeCompleto} e tenho {Idade} anos");
        }
    }
}