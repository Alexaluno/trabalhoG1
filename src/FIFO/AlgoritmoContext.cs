using Algoritmos.Interfaces;
using System.Collections.Generic;

namespace Algoritmos
{
    public class AlgoritmoContext : IAlgoritmoContext
    {
        private ICollection<Algoritmo> _repository;
        public AlgoritmoContext()
        {
            _repository = new List<Algoritmo>();
        }
        public void AdicionarProcesso(Algoritmo fifo)
        {
            _repository.Add(fifo);
        }

        public ICollection<Algoritmo> BuscarProcessos()
        {
            return _repository;
        }
    }
}
