using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos
{
    public class Algoritmo : Processo
    {
        public Algoritmo(
            int numero, 
            int tempoProcesso, 
            int inicioProcesso, 
            int fimProcosso) : base( numero, tempoProcesso, inicioProcesso, fimProcosso)
        {
            if (Numero <= 0)
                Mensagem.Add("O numero ", $"{ Numero } do processo não pode ser negativo");

          

            if (TempoProcesso <= 0)
                Mensagem.Add("O Tempo ", $"{ TempoProcesso } do processo não pode ser negativo");

            if (TempoProcesso > 80)
                Mensagem.Add("O Tempo ", $"{ TempoProcesso } do processo não pode ser maior que 80");

        }

        public override bool EhValido()
        {
            return !(Mensagem.Count() > 0);
        }

        public override string ToString()
        {
            var msg = string.Empty;
            foreach (var item in Mensagem)
            {
                msg += "\n" + item.Key + item.Value;
            }
            return msg;
        }

    }
}
