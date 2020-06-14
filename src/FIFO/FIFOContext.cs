using FIFO.Interfaces;
using System.Collections.Generic;

namespace FIFO
{
    public class FIFOContext : IFIFOContext
    {
        private ICollection<FIFO> _repository;
        public FIFOContext()
        {
            _repository = new List<FIFO>();
        }
        public void AdicionarProcesso(FIFO fifo)
        {
            _repository.Add(fifo);
        }

        public ICollection<FIFO> BuscarProcessos()
        {
            return _repository;
        }
    }
}
