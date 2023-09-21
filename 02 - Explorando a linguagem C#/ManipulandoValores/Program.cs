using System;
using static System.Console;
using System.Globalization;

namespace ManipulandoValores
{
    class Program
    {
        static void Main(string[] args)
        {
            //concatenando strings
            //concatenando valores
            string numero1 = "10";
            string numero2 = "20";
            string resultado = numero1 + numero2;
            WriteLine(resultado);
            
            //formatando valores monetários
            decimal valorMonetario = 82.40m;
            WriteLine($"{valorMonetario:C}");
            
            //alterando a localização do código
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
            decimal valorMonetarioDolar = 1082.40m;
            WriteLine($"{valorMonetario:C}");
            
            //Alterando a localização da cultura
            WriteLine($"{valorMonetarioDolar.ToString("C", CultureInfo.CreateSpecificCulture("pt-br"))}");
            
            //Formatação personalizada
            WriteLine($"{valorMonetarioDolar.ToString("C2")}");
            
            //representando porcentagem
            double porcentagem = .3421;
            WriteLine(porcentagem.ToString("P"));

            int numero = 123456;
            WriteLine(numero.ToString("##-##-##"));

            //DateTime
            DateTime data = DateTime.Now;
            WriteLine(data);
            
            //formatando data e hora
            WriteLine(data.ToShortDateString());
            WriteLine(data.ToShortTimeString());
            
            //datetime com try parse
            string dataString = "2022-04-17 18:00";
            DateTime data2 = DateTime.Parse(dataString);
            WriteLine(data2);
            
            string dataString2 = "2022-05-20 17:00";
            DateTime.TryParseExact(dataString2,
                          "yyy-MM-dd HH:mm", 
                                CultureInfo.InvariantCulture, 
                                DateTimeStyles.None, 
                                out data2);
            
            //validando o retorno do tryparse
            
            bool sucesso = DateTime.TryParseExact(dataString2,
                "yyy-MM-dd HH:mm", 
                CultureInfo.InvariantCulture, 
                DateTimeStyles.None, 
                out data2);

            if (sucesso)
                WriteLine($"Convertido com sucesso! Data: {data2}");
            else
                WriteLine($"{dataString2} não é uma data válida");
            





        }
    }
}