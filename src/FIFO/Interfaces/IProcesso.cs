﻿namespace FIFO
{
    public interface IProcesso
    {
        bool EhValido();
        void ValidarProcesso(string nomeAtributo, string valorAtribuito);
    }
}