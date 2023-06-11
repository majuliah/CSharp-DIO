using System;
using System.Collections.Generic;
using System.Globalization;
using static System.Console;
using AppBanco.Enums;


namespace AppBanco
{
    class Program
    {
        private static List<Conta> listContas = new List<Conta>();
        static void Main(string[] args)
        {
            WriteLine($"Welcome to DioBank");
            OpcaoUsuario();
        }

        private static char ObterOpcaoUsuario()
        {
            WriteLine();
            WriteLine($"  --  Dio bank  --");
            
            WriteLine($"[ 1 ] - Listar contas ");
            WriteLine($"[ 2 ] - Inserir nova conta ");
            WriteLine($"[ 3 ] - Transferir ");
            WriteLine($"[ 4 ] - Sacar ");
            WriteLine($"[ 5 ] - Depositar ");
            WriteLine($"[ C ] - Limpar tela ");
            WriteLine($"[ X ] - Sair ");
            WriteLine($" ");

            char opcaoUsuario = char.Parse(ReadLine().ToUpper());
            WriteLine();
            return opcaoUsuario;
        }
        
        private static void OpcaoUsuario()
        {
            char opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario != 'X')
            {
                switch (opcaoUsuario)
                {
                    case '1':
                        ListarContas();
                        break;
                    case '2':
                        InserirConta();
                        break;
                    case '3':
                        Transferir();
                        break;
                    case '4': 
                        Sacar();
                        break;
                    case '5':
                        Depositar();
                        break;
                    case 'C':
                        Clear();
                        break;
                    default:
                        throw new ArgumentException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            WriteLine($"Obrigada por utilizar o Bank Dio!");
            ReadLine();
        }
        
        private static void InserirConta()
        {
            int entradaTipoConta;
            string entradaNome, entradaCpf;
            double entradaSaldo = 0.0, entradaCredito = 0.0;
            WriteLine("Inserir nova Conta: ");

            WriteLine("Digite 1- Pessoa Física || Digite 2- Pessoa Jurídica");
            entradaTipoConta = int.Parse(ReadLine());
            
            WriteLine("Entre com o nome completo");
            entradaNome = Console.ReadLine();
            
            WriteLine("Entre com o CPF");
            entradaCpf = Console.ReadLine();
            
            WriteLine("Entre com um saldo maior que R$0,00");
            entradaSaldo = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            
            WriteLine("Entre com um saldo maior que R$0,00");
            entradaCredito = double.Parse(ReadLine(), CultureInfo.InvariantCulture);
            
            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoConta,
                saldo: entradaSaldo,
                credito: entradaCredito,
                nome: entradaNome);
            
            listContas.Add(novaConta);
        }
        
        private static void ListarContas()
        {
            WriteLine("Listar Contas");
            if (listContas.Count == 0)
            {
                WriteLine("Nenhuma conta cadastrada.");
                return;
            }

            for (int i = 0; i < listContas.Count; i++)
            {
                Conta conta = listContas[i];
                WriteLine("#{0} - ", i);
                WriteLine(conta);
            }
        }
        
        private static void Sacar()
        {
            WriteLine("Digite o número da conta");
            int indiceConta = int.Parse(ReadLine(), CultureInfo.InvariantCulture);

            WriteLine("Digite agora o valor que deseja sacar");
            double valorDeposito = double.Parse(ReadLine(), CultureInfo.InvariantCulture);

            listContas[indiceConta].Sacar(valorDeposito);
        }

        private static void Depositar()
        {
            WriteLine("Digite o número da conta: ");
            int indiceConta = int.Parse(ReadLine());

            WriteLine("Digite o valor para ser depositado: ");
            double valorDepositado = double.Parse(ReadLine());
            
            listContas[indiceConta].Depositar(valorDepositado);
        }

        private static void Transferir()
        {
            WriteLine("Digite o número da conta origem: ");
            int indiceContaOrigem = int.Parse(ReadLine(), CultureInfo.InvariantCulture);

            WriteLine("Digite o número da conta de destino: ");
            int indiceContaDestino = int.Parse(ReadLine(), CultureInfo.InvariantCulture);

            WriteLine("Entre com o valor de transferência: ");
            double valorTransferencia = double.Parse(ReadLine());
            listContas[indiceContaOrigem].Transferir(valorTransferencia, listContas[indiceContaDestino]);
        }
        
    }
}