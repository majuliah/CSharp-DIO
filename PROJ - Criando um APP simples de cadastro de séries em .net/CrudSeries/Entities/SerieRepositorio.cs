using System;
using System.Collections.Generic;
using CrudSeries.Interfaces;

namespace CrudSeries.Entities
{
    /// <summary>
    /// Contem a lista de séries e as operações para manipulá-las
    /// Ela faz o intermédio entre o programa e a memória. O "banco" é a lista.
    /// </summary>
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        
        public void Atualiza(int id, Serie atualizaSerie)
        {
            listaSerie[id] = atualizaSerie;
        }
        
        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }
        
        public void Insere(Serie novaSerie)
        {
            listaSerie.Add(novaSerie);
        }
        
        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }
        
        public Serie RetornoPorId(int id)
        {
            return listaSerie[id];
        }
    }
}