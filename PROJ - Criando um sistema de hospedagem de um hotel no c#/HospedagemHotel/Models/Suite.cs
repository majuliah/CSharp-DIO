namespace HospedagemHotel.Models
{
    public class Suite
    {
        public string TipoSuite { get; set; }
        public int CapacidadeHospedes { get; set; }
        public decimal ValorDiaria { get; set; }

        public Suite(string tipoSuite, int capacidadeHospedes, decimal valorDiaria)
        {
            TipoSuite = tipoSuite;
            CapacidadeHospedes = capacidadeHospedes;
            ValorDiaria = valorDiaria;

        }
    }
}