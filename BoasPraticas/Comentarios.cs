using static System.Console;

namespace BoasPraticas
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Módulo 1: Comentários");

            WriteLine("Comentários de linha única");
            //eles são feitos com duas barras

            WriteLine("Comentários de múltiplas linhas");
            /*
            eles são feitos 
            com barra, dois asteriscos
            e outra barras
            */

            Pessoa exemplo = new Pessoa();
            exemplo.calculaIdade(2021, 1999);
        }
    }

    ///<summary>
    ///Isso é um descritivo da classe. Quando 
    /// passamos o mouse em cima, aparece este comentário.
    ///</summary>
    public class Pessoa
    {
        public int Idade { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }


        ///<summary>
        ///Isso é um descritivo do MÈTODO. Quando 
        /// passamos o mouse em cima, aparece este comentário.
        ///</summary>
        public void Falar()
        {
            WriteLine("Summary também funciona para métodos!");
        }

        ///<summary>
        ///Isso é um descritivo do método e de seus parâmetros! Quando 
        /// passamos o mouse em cima, aparece este comentário.
        ///</summary>
        ///<param name = "anoAtual"> É o ano em que estamos</param>
        ///<param name = "anoNascimento">É o ano em que a pessoa nasceu </param>
        ///<returns>Retorna a idade da pessoa</returns>
        public int calculaIdade(int anoAtual, int anoNascimento)
        {
            int idade = anoAtual - anoNascimento;
            return idade;
        }
    }
}
