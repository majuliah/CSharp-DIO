using static System.Console;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal _precoInicial = 0;
        private decimal _precoPorHora = 0;
        private List<string> _veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            _precoInicial = precoInicial;
            _precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            WriteLine("Digite a placa do veículo para estacionar:");
            string placa = ReadLine();
            _veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            WriteLine("Digite a placa do veículo para remover:");
            string placa = ReadLine();

            // Verifica se o veículo existe
            if (_veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = int.Parse(ReadLine());
                decimal valorTotal = _precoInicial + (_precoPorHora * horas); 
                
                _veiculos.Remove(placa);
                WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
                WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            
        }
        public void ListarVeiculos()
        {
            if (_veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in _veiculos)
                {
                    WriteLine($"PLACA: {veiculo.ToUpper()}");
                }
            }
            else
            {
                WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
