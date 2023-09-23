using System;

namespace ExcessoesEcolecoes.Models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ocorreu uma exceção {e.Message}");
            }
            
        }

        public void Metodo2()
        {
            Metodo3();
        }

        public void Metodo3()
        {
            Metodo4();
        }

        public void Metodo4()
        {
            throw new Exception("Aconteceu uma exceção");
        }
    }
}