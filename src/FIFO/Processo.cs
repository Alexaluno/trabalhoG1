﻿using System.Collections.Generic;

namespace FIFO
{
    public abstract class Processo : IProcesso
    {
        protected Processo(int numero, int tempoProcesso)
        {
            Mensagem = new Dictionary<string, string>();
            Numero = numero;
            TempoProcesso = tempoProcesso;
        }

        protected Dictionary<string, string> Mensagem { get; set; }
        protected int Numero { get; set; }
        protected int TempoProcesso { get; set; }

        public void ValidarProcesso(string nomeAtributo, string valorAtribuito)
        {
            Mensagem.Add(nomeAtributo, valorAtribuito);
        }

        public abstract bool EhValido();
    }
}
