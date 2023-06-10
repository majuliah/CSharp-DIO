using System;
using static System.Console;
using CrudSeries.Entities;
using CrudSeries.Enums;

namespace CrudSeries
{
    
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
            OpcaoUsuario();
        }

        private static char ObterOpcaoUsuario()
        {
            WriteLine();
            WriteLine("ProgFlix séries");
            WriteLine("Escolha uma opção: ");
            
            WriteLine("[ 1 ] - Listar Séries ");
            WriteLine("[ 2 ] - Inserir nova série ");
            WriteLine("[ 3 ] - Atualizar série ");
            WriteLine("[ 4 ] - Excluir série ");
            WriteLine("[ 5 ] - Visualizar série ");
            WriteLine("[ C ] - Limpar tela ");
            WriteLine("[ X ] - Sair ");
            WriteLine();
            
            char opcaoUsuario = char.Parse(ReadLine().ToUpper());
            WriteLine();
            return opcaoUsuario;
        }

        private static void ListarSeries()
        {
            WriteLine($"Lista de séries: ");
            var lista = repositorio.Lista();

            if (lista.Count == 0)
            {
                WriteLine($"Nenhuma série cadastrada.");
                return;
            }
            foreach (var serie in lista)
            {
                var excluido = serie.retornaExlcuido();
                
                WriteLine($"#ID {serie.GetId()}:  -  {serie.GetTitulo()}" + (excluido ? "*Excluída*" : $""));
            }
        }

        private static void InserirSerie()
        {
            WriteLine($"Inserir nova série");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            
            WriteLine();
            WriteLine($"Digite um gênero listado acima: ");
            int entradaGenero = int.Parse(ReadLine());
            
            WriteLine($"Entre com o título da série: ");
            string entradaTitulo = ReadLine();
            
            WriteLine($"Entre com o ano de lançamento");
            int entradaAno = int.Parse(ReadLine());

            WriteLine($"Entre com a descrição");
            string entradaDescricao = ReadLine();

            Serie novaSerie = new Serie(id : repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            repositorio.Insere(novaSerie);
        }

        private static void AtualizaSerie()
        {
            WriteLine($"Digite o id da série: ");
            int idSerie = int.Parse(ReadLine());
            
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }
            
            WriteLine();
            WriteLine($"Digite um gênero listado acima: ");
            int entradaGenero = int.Parse(ReadLine());
            
            WriteLine($"Entre com o título da série: ");
            string entradaTitulo = ReadLine();
            
            WriteLine($"Entre com o ano de lançamento");
            int entradaAno = int.Parse(ReadLine());

            WriteLine($"Entre com a descrição");
            string entradaDescricao = ReadLine();

            Serie atualizaSerie = new Serie(id : idSerie,
                genero: (Genero)entradaGenero,
                titulo: entradaTitulo,
                ano: entradaAno,
                descricao: entradaDescricao);
            repositorio.Atualiza(idSerie, atualizaSerie);
        }

        private static void ExcluirSerie()
        {
            WriteLine($"Entre com o ID da série para ser excluida: ");
            int id = int.Parse(ReadLine());
            
            repositorio.Exclui(id);
        }

        private static void VisualizarSerie()
        {
            WriteLine($"Digite o ID da série para ser visualizada: ");
            int idSerie = int.Parse(ReadLine());

            var serie = repositorio.RetornoPorId(idSerie);
            WriteLine(serie);
        }

        private static void OpcaoUsuario()
        {
            char opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario != 'X')
            {
                switch (opcaoUsuario)
                {
                    case '1':
                        ListarSeries();
                        break;
                    case '2':
                        InserirSerie();
                        break;
                    case '3':
                        AtualizaSerie();
                        break;
                    case '4': 
                        ExcluirSerie();
                        break;
                    case '5':
                        VisualizarSerie();
                        break;
                    case 'C':
                        Clear();
                        break;
                    default:
                        throw new ArgumentException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            WriteLine($"Obrigada por utilizar o SerieFlix!");
            ReadLine();
        }
        
        
    }
}
