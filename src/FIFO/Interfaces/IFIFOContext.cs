using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIFO.Interfaces
{
    public interface IFIFOContext
    {
        void AdicionarProcesso(FIFO fifo);
        ICollection<FIFO> BuscarProcessos();
    }
}
