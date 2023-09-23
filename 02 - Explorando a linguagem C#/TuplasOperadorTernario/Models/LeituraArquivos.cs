using System;
using System.IO;

namespace TuplasOperadorTernario.Models
{
    public class LeituraArquivos
    {
        public (bool sucesso, string[] linhas, int quantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                //um método só retorna um valor. com tuplas, pode retornar mais de um valor
                return (true, linhas, linhas.Length);
            }
            catch (Exception e)
            {
                return (false, new string[0], 0);
            }
        }

        // public void Deconstruct(out string nome, out string sobrenome)
        // {
        //     nome = nome;
        //     sobrenome = sobrenome;
        // }
    }
}