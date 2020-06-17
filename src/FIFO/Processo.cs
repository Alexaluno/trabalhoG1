using System.Collections.Generic;

namespace Algoritmos
{
    public abstract class Processo : IProcesso
    {
        protected Processo( int numero, int tempoProcesso, int inicioProcesso, int fimProcosso)
        {
            Mensagem = new Dictionary<string, string>();
            Numero = numero;
            TempoProcesso = tempoProcesso;
            InicioProcesso = inicioProcesso;
            FimProcosso = fimProcosso;
        }

        protected Dictionary<string, string> Mensagem { get; set; }
        public int Numero { get; set; }
        public int TempoProcesso { get; set; }
        public int InicioProcesso { get; set; }
        public int FimProcosso { get; set; }
        
        public void ValidarProcesso(string nomeAtributo, string valorAtribuito)
        {
            Mensagem.Add(nomeAtributo, valorAtribuito);
        }

        public abstract bool EhValido();
    }
}
