using System;

namespace ProrpiedadesMetodosConstrutores
{
    /// <summary>
    /// Discutindo propriedades e métodos
    /// </summary>
    public class Pessoa
    {
        public Pessoa()
        {
            
        }
        //encapsulamento -> protegendo de alterações externas, validando as alterações através de propriedades e métodos
        private string _nome;
        //no private somente a classe pode alterar os valores 
        private int _idade;
        public string Nome
        {
            get => _nome.ToUpper(); //body expression

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