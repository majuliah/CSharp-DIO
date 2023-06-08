using static System.Console;
using System;
using System.Collections.Generic;

namespace BoasPraticas
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Arrays");

            int[] arrayInteiros = new int[3];
            arrayInteiros[0] = 42;
            arrayInteiros[1] = 22;
            arrayInteiros[2] = 72;

            for(int i = 0; i < arrayInteiros.Length; i++)
            {
                WriteLine($"{i+1}ª posição: " + arrayInteiros[i]);
            }

            foreach(int value in arrayInteiros)
            {
                WriteLine($"{value}");
            }

            //redimensionando um array

            Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);
            //vai dobrar a capacidade do array
            //o resize não aumenta o array, ele recria um array e copia a referência do antigo para o novo

            int[] arrayDobrado = new int[arrayInteiros.Length * 2];
            Array.Copy(arrayInteiros, arrayDobrado, arrayInteiros.Length);

            foreach(int value in arrayDobrado)
            {
                WriteLine($"{value}");
            }


            WriteLine("Listas");

            List<string> listString = new List<string>();
            listString.Add("SP");
            listString.Add("MG");
            listString.Add("RJ");
            
            WriteLine($"{listString.Count}, {listString.Capacity}");
            listString.Add("AC");
            WriteLine($"{listString.Count}, {listString.Capacity}");
            listString.Remove("SP");

            for(int i = 0; i < listString.Count; i++)
            {
                WriteLine($"{i+1}ª posição: " + listString[i]);
            }

            foreach(string value in listString)
            {
                WriteLine($"{value}");
            }
        }
    }
}
