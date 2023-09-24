using System;
using System.Collections.Generic;
using System.IO;
using NuggetSerializarEatributos.Models;
using static System.Console;
using Newtonsoft.Json;

namespace NuggetSerializarEatributos
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Nuget, Serializar e Atributos no c#");
            //Pacote -> conjunto, compartilhamento e reuso de código.
                    //um pequeno projeto que resolve um problema específico
            
            //Nuget -> gerenciador de pacotes, permite que desenvolvedores compartilhem códigos e bibliotecas
                    // no javascript por exemplo, o gerenciador de pacotes é o npm 😀
            
            //Serialização e Deserialização ->
                    // Serialização: transformar objetos em fluxo de bytes para armazenar ou transmitir;
                    //Transforma o estado do objeto e transformar no fomato do destino que queremos armazenar, como um banco de dados, um arquivo txt ou armazenar na memória por exemplo.
                    
                    //Deserialização: Dados de um arquivo e transformá-lo em um objeto.
                    //O fomato JSON é uma forma de serialização, fromato texto -> JavaScript Notation Object é um formato de texto que segue a sintaxe do javascript, usado para transmitir entre aplicações
                    
                    // .NET -> JSON -> JAVA
                    //           |
                    //       { "Id" : 1, "Produto" : "P1", "Valor" : 10.50}
            
            //🚀 Serialização na prática 🚀

            Vendas venda1 = new Vendas(1, "Material Escritório", 25.00M);
            
            string serializado = JsonConvert.SerializeObject(venda1, Formatting.Indented);
            //File.WriteAllText(@"Arquivos/vendas.json", serializado);
            WriteLine(serializado);
            
            //serializando uma coleção
            Vendas venda2 = new Vendas(2, "Jogo", 110.00M);
            Vendas venda3 = new Vendas(3, "Livro", 130.00M);
            Vendas venda4 = new Vendas(4, "Teclado", 150.00M);

            List<Vendas> listaVendas = new List<Vendas>();
            listaVendas.Add(venda2);
            listaVendas.Add(venda3);
            listaVendas.Add(venda4);
            
            //File.WriteAllText(@"Arquivos/vendas1.json", serializado);
            string listaSerializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
            
            //dateTime em json
            DateTime dataAtual = DateTime.Now;
            
            Vendas venda5 = new Vendas(5, "Jogo", 110.00M, dataAtual);
            Vendas venda6 = new Vendas(6, "Livro", 130.00M, dataAtual);
            Vendas venda7 = new Vendas(7, "Teclado", 150.00M, dataAtual);
            
            List<Vendas> listaVendas2 = new List<Vendas>();
            listaVendas.Add(venda5);
            listaVendas.Add(venda6);
            listaVendas.Add(venda7);
            
            //File.WriteAllText(@"Arquivos/vendas2.json", serializado);
            string listaSerializado2 = JsonConvert.SerializeObject(listaVendas2, Formatting.Indented);
            
            //Deserializando um objeto
            


        }
    }
}