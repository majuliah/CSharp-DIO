using System;
using CelApp.Models;
using static System.Console;

namespace CelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Smartphone Nokia ->");
            SmartPhone nokiaLumia =
                new Nokia(numero: "99944433356", model: "Lumia 630", imei: "99999999", memoria: 128);
            nokiaLumia.Ligar();
            nokiaLumia.InstalarAplicativo("Angry Birds");
            
            WriteLine("\n");
            
            WriteLine("Iphone ->");
            SmartPhone iPhone = 
                new Iphone(numero: "8889991010", model: "Iphone 25", imei: "000000", memoria: 64);
            iPhone.ReceberLigacao();
            iPhone.InstalarAplicativo("Instagram");
            
        }
    }
}