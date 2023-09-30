using System;
using System.Collections.Generic;
using HospedagemHotel.Models;
using static System.Console;

namespace HospedagemHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to Majulha's Hotel 😀");
            // Cria os modelos de hóspedes e cadastra na lista de hóspedes
            List<Pessoa> hospedes = new List<Pessoa>();

            Pessoa p1 = new Pessoa(nome: "Hóspede 1");
            Pessoa p2 = new Pessoa(nome: "Hóspede 2");

            hospedes.Add(p1);
            hospedes.Add(p2);

            // Cria a suíte
            Suite suite = new Suite(tipoSuite: "Premium", capacidadeHospedes: 2, valorDiaria: 30);

            // Cria uma nova reserva, passando a suíte e os hóspedes
            Reserva reserva = new Reserva(diasReservados: 5);
            reserva.CadastrarSuite(suite);
            reserva.CadastrarHospedes(hospedes);

            // Exibe a quantidade de hóspedes e o valor da diária
            WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
            WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
        }
        
    }
}