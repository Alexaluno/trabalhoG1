using System.Collections.Generic;

namespace Algoritmos.Interfaces
{
    public interface IAlgoritmoContext
    {
        void AdicionarProcesso(Algoritmo fifo);
        ICollection<Algoritmo> BuscarProcessos();

        void LimparProcessos();
    }
}
