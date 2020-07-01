using Algoritmos;
using Algoritmos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class AlgoritmoFIFO : IAlgoritmoContext
    {
        private ICollection<Algoritmo> _repository;
        public void AdicionarProcesso(Algoritmo fifo)
        {
            _repository.Add(fifo);
        }

        public ICollection<Algoritmo> BuscarProcessos()
        {
            return _repository;
        }

        public void LimparProcessos()
        {
            _repository.Clear();
        }
    }
}
