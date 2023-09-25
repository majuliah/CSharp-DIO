﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using NuggetSerializarEatributos.Models;
using static System.Console;

namespace TiposEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Tipos Especiais no C#");
            //nulos
            
            bool? desejaReceberEmail = null;

            if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
            {
                WriteLine("usuário optou por receber email");
            }
            else
            {
                WriteLine("Usuário optou por não receber email");
            }

            string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
            List<Vendas> listaVendas = JsonConvert.DeserializeObject<List<Vendas>>(conteudoArquivo);

            foreach (var item in listaVendas)
            {
                WriteLine($"Id: {item.Id}, Produto: {item.Nome}, Preço: {item.Valor}, Data: {item.DataVenda}, Desconto: {(item.Desconto.HasValue ? $"Deconto de: {item.Desconto}" : "")}");
            }

            //tipos anônimos
            // fornece foma de encapsular modos somente leitura.

            var tipoAnonimo = new { Nome = "Maju", Sobrenome = "Majulha", Altura = 1.80 };
            WriteLine($"Nome: {tipoAnonimo.Nome}, Sobrenome: {tipoAnonimo.Sobrenome}, Altura: {tipoAnonimo.Altura}");

            var listaAnonima = listaVendas.Select(x => new 
            {
                x.Nome, x.Valor
            });

            foreach (var item in listaAnonima)
            {
                WriteLine($"Produto: {item.Nome}, Valor: {item.Valor}");
            }
            
            //dynamics
            dynamic variavelDinamica = 50;
            WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, valor: {variavelDinamica}");

            variavelDinamica = "Texto";
            WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, valor: {variavelDinamica}");

            variavelDinamica = false;
            WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, valor: {variavelDinamica}");

            
        }
    }
}